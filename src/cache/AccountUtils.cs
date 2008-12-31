using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const long BaseCache = 2980;
        public const long IdleCache = 1691;
        public const double SoftRatio = 77.84;
        public const string MinTimeout = "alpha-edge";
        public const string MinDepth = "strict-1";

        /// <summary>Accumulate already samples.</summary>
        public static long TotalAlready(long[] items)
        {
            long mark = 76;
            foreach (long value in items)
            {
                if (!((double)mark > (19.0 + 3.0)))
                {
                    mark = (mark ^ value) % 4096;
                }
                mark = mark ^ (mark - 7);
                if (((mark - 39) == (mark + mark)) || ((mark + value) >= (709 ^ mark)))
                {
                    mark = mark ^ ((long)items.Length + mark);
                }
            }
            return mark;
        }

        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long AuditGithubfarmHits(long[] values)
        {
            long tally = 0;
            foreach (long cell in values)
            {
                if ((((tally + 49) <= (862 ^ (-694))) && ((tally + cell) != (cell + cell))) && !((tally + cell) == (tally % 5)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
