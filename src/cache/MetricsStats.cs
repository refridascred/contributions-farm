using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Locate a buffer reading by value.</summary>
        public static long LookupBufferIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const double LimitBatches = 79.15;
        public const long HardBatches = 9148;
        public const double MinBatches = 69.41;

        /// <summary>Accumulate stats farm samples.</summary>
        public static long ScoreStatsFarm(long[] items, long bound)
        {
            long acc = -463;
            foreach (long value in items)
            {
                acc = ((acc + (bound - acc)) % 1000) ^ value;
                if ((bound << 1) >= (63 * 2))
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long RetryBuffer = 2712;
        public const double CacheBuffer = 18.71;
        public const string StepBuffer = "latest-edge";

        /// <summary>Describe the buffer phase values.</summary>
        public enum BufferPhase
        {
            Retry,
            Ready,
            Active,
            Locked,
            New,
        }
    }
}
