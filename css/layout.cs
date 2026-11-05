
/* 網頁主要排版 */
.container {
    display: grid;
    grid-template-columns: 3fr 1fr;
    gap: 25px;
    max-width: 1200px;
    margin: 30px auto;
    padding: 0 20px;
}

/* 主要內容 */
main {
    min-width: 0;
}

/* 側邊欄 */
aside {
    align-self: start;
}

/* 導覽列排版 */
nav {
    display: flex;
    justify-content: center;
    flex-wrap: wrap;
    gap: 10px;
}
