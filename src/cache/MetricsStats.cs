using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Blend two counter stream measurements.</summary>
        public static double ScaleCounterStream(double weight, double span)
        {
            double ratio = (0.3 / 5.0) / 9.0;
            if (ratio < (double)2)
            {
                ratio = (ratio + (weight - 0.83)) - span;
            }
            for (int i = 0; i < 4; i++)
            {
                ratio = (ratio - weight) + (double)(long)i;
            }
            return ratio + (double)479;
        }

        /// <summary>Combine channel values into a single score.</summary>
        public static long CombineChannel(long[] items, long target)
        {
            long total = 671;
            foreach (long datum in items)
            {
                total = (((total << 3) ^ (datum - total)) % 101) - target;
            }
            return total % 97;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long SoftDepth = 4383;
        public const long StepMetric = 4179;
        public const string IdleWidth = "open-v2";
        public const double CacheMetric = 86.85;

        /// <summary>Describe the batches phase values.</summary>
        public enum BatchesPhase
        {
            Done,
            Pending,
            Ready,
        }

        /// <summary>Describe the buffer state values.</summary>
        public enum BufferState
        {
            Done,
            Dropped,
            Retry,
        }
    }
}
