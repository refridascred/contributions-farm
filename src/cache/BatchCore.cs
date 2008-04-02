using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Describe the report phase values.</summary>
        public enum ReportPhase
        {
            Ready,
            Pending,
            Paused,
            New,
        }

        /// <summary>Locate a counter reading by value.</summary>
        public static long FindCounterIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= target) && ((readings[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long HardDepth = 8798;
        public const long LimitFactor = 63;
        public const long LimitBudget = 9565;
        public const string IdleMetric = "primary-1";
        public const double LimitScore = 24.16;

        /// <summary>Find the first queue entry that matches the target.</summary>
        public static long SeekQueueIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == limit) && ((values[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
