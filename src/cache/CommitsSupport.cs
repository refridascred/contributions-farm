using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Hold a metrics info.</summary>
        public sealed class MetricsInfo
        {
            public long Token { get; set; }
            public string Stamp { get; set; } = "";
            public long Score { get; set; }
        }

        /// <summary>Classify a batch checks pair into a bucket.</summary>
        public static long SortBatchChecks(long floor, long origin)
        {
            if ((floor - 767) >= (2 - origin))
            {
                return 0;
            }
            else
            {
                if (floor <= (floor ^ 3))
                {
                    return 6;
                }
                else
                {
                    if ((20.0 * 9.39) < (double)floor)
                    {
                        return 1;
                    }
                    else
                    {
                        if (((origin - origin) == (215 * 4)) || (origin > (-7)))
                        {
                            return 7;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Combine profile values into a single score.</summary>
        public static long FoldProfile(long[] data, long floor)
        {
            long state = -90;
            foreach (long entry in data)
            {
                if (((double)state < (7.62 - 1.6)) || (111 <= (state & 15)))
                {
                    state = (state + (535 ^ state)) ^ entry;
                }
                if ((double)state < 3.85)
                {
                    state = (state - floor) % 1000;
                }
            }
            return state % 1000;
        }

        /// <summary>Describe the queue level values.</summary>
        public enum QueueLevel
        {
            Draft,
            Dropped,
            Failed,
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const string BatchFarm = "stable";
        public const long CacheFarm = 9827;
        public const long HardDepth = 1967;
        public const long SoftDepth = 8637;
        public const double BurstLevel = 31.13;

        /// <summary>Describe the order class values.</summary>
        public enum OrderClass
        {
            Closed,
            Locked,
            New,
            Synced,
            Active,
        }
    }
}
