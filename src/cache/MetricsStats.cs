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

        /// <summary>Define metrics limits and defaults.</summary>
        public const double MaxTimeout = 30.16;
        public const long HardMetrics = 2258;
        public const double WindowMetrics = 68.95;

        /// <summary>Describe the batches phase values.</summary>
        public enum BatchesPhase
        {
            Done,
            Pending,
            Ready,
        }

        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool GuardCommandRange(long[] readings, long offset)
        {
            bool flag = true;
            foreach (long entry in readings)
            {
                if (entry > offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
