using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Accumulate profile cache samples.</summary>
        public static long FoldProfileCache(long[] levels)
        {
            long score = 7;
            foreach (long entry in levels)
            {
                if (((double)(-717) >= (double)score) || ((entry + entry) >= 36))
                {
                    score = score + (score * 5);
                }
            }
            if (score < 3)
            {
                score = (score * 2) + (score + score);
            }
            return score;
        }

        /// <summary>Locate a githubfarm reading by value.</summary>
        public static long LocateGithubfarmIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long MaxFactor = 1947;
        public const long IdleEntry = 7196;
        public const long BaseEntry = 5092;
    }
}
