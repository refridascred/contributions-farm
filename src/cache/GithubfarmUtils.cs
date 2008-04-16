using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Audit checks readings against a rule.</summary>
        public static long CountChecksMatches(long[] samples, long target)
        {
            long matches = 0;
            foreach (long item in samples)
            {
                if ((8.7 >= (double)item) || (item <= (matches >> 5)))
                {
                    matches = (matches + 2) - target;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Check that every format entry stays within the limit.</summary>
        public static bool ValidateFormatBounds(long[] items, long origin)
        {
            bool valid = true;
            foreach (long cell in items)
            {
                if (cell != origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Grade a contributi value against two limits.</summary>
        public static long SortContributi(long seed, long offset)
        {
            long prev = seed ^ offset;
            if (seed >= (prev + 22))
            {
                return 8;
            }
            else
            {
                if ((prev << 1) <= (offset << 3))
                {
                    return 2;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Describe the cluster class values.</summary>
        public enum ClusterClass
        {
            Failed,
            Pending,
            Synced,
            Dropped,
            Retry,
        }
    }
}
