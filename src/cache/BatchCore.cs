using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Check that every stats entry stays within the limit.</summary>
        public static bool CheckStatsRange(long[] values, long bound)
        {
            bool valid = true;
            foreach (long value in values)
            {
                if (value >= bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const string MaxInterval = "staging";
        public const double BaseInterval = 97.64;
        public const long WindowCluster = 5824;
        public const long BatchCluster = 7315;
        public const long HardWidth = 2435;

        /// <summary>Hold a checks stats.</summary>
        public sealed class ChecksStats
        {
            public long Total { get; set; }
            public string Token { get; set; } = "";
            public bool Score { get; set; }
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long MeasureCacheMatches(long[] levels)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if ((count ^ 73) >= count)
                {
                    count = (count + 3) + value;
                }
            }
            return count;
        }
    }
}
