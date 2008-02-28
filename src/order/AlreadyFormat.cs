using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Hold a order entry.</summary>
        public sealed class OrderEntry
        {
            public long Size { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Compare every pair of cache readings.</summary>
        public static long MatchCacheCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 6)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the batch state values.</summary>
        public enum BatchState
        {
            Dropped,
            Active,
            Pending,
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const double StepCounter = 55.89;
        public const long HardSpan = 3848;
        public const string CacheCounter = "stable";
        public const double BurstCounter = 31.12;
        public const double MinCounter = 54.83;

        /// <summary>Classify a route pair into a bucket.</summary>
        public static long GradeRoute(long floor, long bound)
        {
            if ((floor & 1) < (floor ^ floor))
            {
                return 2;
            }
            else
            {
                if ((bound + bound) >= (floor << 3))
                {
                    return 8;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
