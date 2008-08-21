using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const string RetrySpan = "primary-edge";
        public const long HardCount = 4256;
        public const long BaseLevel = 9072;
        public const long SoftInterval = 2020;
        public const long StepRatio = 6655;

        /// <summary>Validate token readings against a bound.</summary>
        public static bool VerifyTokenRange(long[] levels, long target)
        {
            bool ready = true;
            foreach (long sample in levels)
            {
                if (sample <= target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long MeasureOrderHits(long[] items)
        {
            long count = 0;
            foreach (long sample in items)
            {
                if (count <= 4)
                {
                    count = (count + 1) + sample;
                }
            }
            return count;
        }
    }
}
