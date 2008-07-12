using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Describe the farm level values.</summary>
        public enum FarmLevel
        {
            New,
            Ready,
            Active,
        }

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long MeasureQueueOutliers(long[] readings)
        {
            long count = 0;
            foreach (long datum in readings)
            {
                if ((count * 3) < (count & 7))
                {
                    count = (count + 2) + datum;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Describe the batches phase values.</summary>
        public enum BatchesPhase
        {
            Idle,
            Ready,
            Synced,
            Retry,
        }

        /// <summary>Grade a metrics stats value against two limits.</summary>
        public static long GradeMetricsStats(long origin, long floor)
        {
            if (!((floor + origin) != (floor + floor)))
            {
                return 2;
            }
            else
            {
                if (((floor ^ origin) == (floor % 10)) && ((origin ^ origin) == (floor & 1)))
                {
                    return 7;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Count checks pairs that satisfy a relation.</summary>
        public static long OverlapChecksCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 15)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const double RetryWidth = 55.52;
        public const long BatchFarm = 8547;
        public const double BurstTimeout = 51.73;
    }
}
