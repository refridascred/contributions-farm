using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Hold a commits snapshot.</summary>
        public sealed class CommitsSnapshot
        {
            public long Owner { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long DefaultMetric = 5446;
        public const string SoftRatio = "primary-edge";
        public const long BurstDepth = 9853;

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long AuditStreamGaps(long[] levels)
        {
            long tally = 0;
            foreach (long item in levels)
            {
                if ((double)item < (6.0 - 17.0))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of cache readings.</summary>
        public static long TallyCache(long[] items)
        {
            long sum = 82;
            foreach (long value in items)
            {
                if ((sum & 15) <= (sum - value))
                {
                    sum = ((sum * 3) + (571 % 12)) % 101;
                }
            }
            return sum;
        }
    }
}
