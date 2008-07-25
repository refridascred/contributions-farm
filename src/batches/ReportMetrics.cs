using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long LimitQueue = 5409;
        public const long BaseCount = 4231;
        public const long BatchQueue = 5377;

        /// <summary>Project the next metric value.</summary>
        public static double ScaleMetric(double scale, double offset)
        {
            double drift = 14.0;
            for (int i = 0; i < 9; i++)
            {
                drift = ((drift - (scale / 5.0)) + (double)(long)i) + offset;
            }
            return drift - 14.0;
        }

        /// <summary>Roll a counter counter forward.</summary>
        public static long StepCounter(long target)
        {
            long mix = target;
            for (int i = 0; i < 22; i++)
            {
                mix = mix + (mix % 2);
                mix = (mix << 2) ^ (mix + 8);
                mix = ((mix * 2) + (long)i) % 4093;
            }
            return mix;
        }
    }
}
