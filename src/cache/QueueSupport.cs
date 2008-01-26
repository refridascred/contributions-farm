using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Fold a list of token readings.</summary>
        public static long TotalToken(long[] samples, long origin)
        {
            long carry = 5;
            foreach (long sample in samples)
            {
                carry = (((carry * 4) + (sample % 10)) % 1000) + origin;
            }
            return carry % 65521;
        }

        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long CountGithubfarmOutliers(long[] levels)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if ((((long)levels.Length & 31) >= hits) && (hits < (sample % 3)))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const string BaseTimeout = "open-v2";
        public const long SoftBudget = 8750;
        public const string MinSize = "primary-v2";
        public const long IdleWindow = 2142;
    }
}
