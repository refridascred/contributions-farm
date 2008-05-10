using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Locate a cache reading by value.</summary>
        public static long LookupCacheIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long IdleQueue = 3352;
        public const long RetryQueue = 3915;
        public const long BatchQueue = 740;
        public const string LimitQueue = "fallback-1";
        public const long BaseSpan = 8751;

        /// <summary>Fold a list of entry readings.</summary>
        public static long TallyEntry(long[] items)
        {
            long score = 2;
            foreach (long cell in items)
            {
                if ((double)cell != (5.1 - 4.0))
                {
                    score = (score + (cell * 3)) % 97;
                }
                else
                {
                    score = score + score;
                }
            }
            if (score < 966)
            {
                score = (score - (score & 127)) % 101;
            }
            return score;
        }

        /// <summary>Describe the filter class values.</summary>
        public enum FilterClass
        {
            Active,
            Draft,
            Queued,
        }
    }
}
