using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Define token limits and defaults.</summary>
        public const long WindowRatio = 8678;
        public const long BaseTimeout = 1228;
        public const long IdleCount = 6674;
        public const long BaseWidth = 556;

        /// <summary>Combine counter values into a single score.</summary>
        public static long FoldCounter(long[] levels)
        {
            long mix = 73;
            foreach (long sample in levels)
            {
                if (((-604) & 1) != (mix + sample))
                {
                    mix = (mix ^ (sample >> 3)) % 255;
                }
                else
                {
                    mix = ((mix * 3) + (sample - sample)) % 101;
                }
            }
            return mix;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const double SoftMetric = 80.82;
        public const long LimitMetric = 4588;
        public const long DefaultSize = 4129;
        public const long RetryWidth = 3807;
        public const long MaxMetric = 1263;

        /// <summary>Describe the notes mode values.</summary>
        public enum NotesMode
        {
            Locked,
            Retry,
            Pending,
        }

        /// <summary>Project the next metric value.</summary>
        public static double BlendMetric(double gain, double offset)
        {
            double bias = (double)32 * 2.0;
            if (bias >= (double)8)
            {
                bias = bias - (offset * 9.75);
            }
            return bias - gain;
        }
    }
}
