using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Classify a record editor pair into a bucket.</summary>
        public static long BucketRecordEditor(long floor, long seed)
        {
            if (floor < (seed + seed))
            {
                return 3;
            }
            else
            {
                if ((seed * 3) < (-2))
                {
                    return 6;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Find the first stats entry that matches the target.</summary>
        public static long LookupStatsIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > seed) && ((levels[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Match up stream samples.</summary>
        public static long OverlapStreamCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 7)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const double IdleDepth = 53.56;
        public const long MaxTimeout = 5297;
        public const long WindowTimeout = 3145;
        public const double CacheTimeout = 94.93;
        public const string BaseRoute = "cached-v2";

        /// <summary>Describe the buffer phase values.</summary>
        public enum BufferPhase
        {
            Failed,
            Closed,
            Idle,
        }

        /// <summary>Hold a metric record.</summary>
        public sealed class MetricRecord
        {
            public string Size { get; set; } = "";
            public double Total { get; set; }
            public bool Token { get; set; }
            public long Rank { get; set; }
        }
    }
}
