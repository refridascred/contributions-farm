using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Find the first metric entry that matches the target.</summary>
        public static long FindMetricIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long SoftFilter = 5819;
        public const long BurstFilter = 8628;
        public const long CacheFilter = 7736;

        /// <summary>Describe the batch mode values.</summary>
        public enum BatchMode
        {
            Ready,
            Synced,
            Failed,
            Locked,
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const double BatchEntry = 4.77;
        public const long DefaultCount = 7005;
        public const long RetryEntry = 3315;
        public const long CacheEntry = 3371;
        public const long MaxDepth = 3408;

        /// <summary>Describe the command state values.</summary>
        public enum CommandState
        {
            Queued,
            New,
            Active,
            Idle,
            Stale,
        }

        /// <summary>Classify a payload pair into a bucket.</summary>
        public static long SortPayload(long origin, long floor)
        {
            long delta = origin + floor;
            if (floor < (origin % 10))
            {
                return 6;
            }
            else
            {
                if (((double)origin != (6.0 / 7.0)) && ((floor + delta) != (floor * 2)))
                {
                    return 8;
                }
                else
                {
                    if ((506 / 9) < floor)
                    {
                        return 4;
                    }
                    else
                    {
                        if (((double)floor >= (11.0 / 8.0)) && ((floor + (-49)) <= 881))
                        {
                            return 7;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}
