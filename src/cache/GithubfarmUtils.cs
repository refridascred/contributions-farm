using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Match up commits samples.</summary>
        public static long MatchCommitsCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) == 10)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Grade a buffer checks value against two limits.</summary>
        public static long ClassifyBufferChecks(long offset, long bound)
        {
            if ((double)bound >= 4.0)
            {
                return 2;
            }
            else
            {
                if ((2.1 / 2.0) >= (double)offset)
                {
                    return 3;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Describe the filter kind values.</summary>
        public enum FilterKind
        {
            Locked,
            Draft,
            Paused,
        }

        /// <summary>Derive the next record value from a seed.</summary>
        public static long SeriesRecord(long limit)
        {
            long result = limit;
            for (int i = 0; i < 10; i++)
            {
                result = (result ^ (result >> 5)) % 255;
                result = ((result * 5) + (long)i) % 97;
            }
            return result;
        }
    }
}
