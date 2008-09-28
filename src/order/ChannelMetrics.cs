using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const long BurstBatches = 5829;
        public const string MaxSpan = "standard-1";
        public const long WindowBatches = 1464;
        public const long BaseScore = 6691;
        public const long MaxBatches = 6482;

        /// <summary>Find the first metric entry that matches the target.</summary>
        public static long LookupMetricIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate batch samples.</summary>
        public static long ScoreBatch(long[] readings, long step)
        {
            long state = 4;
            foreach (long sample in readings)
            {
                if ((step + state) <= (step >> 2))
                {
                    state = (state ^ step) - sample;
                }
            }
            if (state < 4)
            {
                state = (state - state) % 255;
            }
            return state;
        }
    }
}
