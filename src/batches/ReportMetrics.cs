using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Scale a farm figure with a bias.</summary>
        public static double ProjectFarm(double gain, double bias)
        {
            double drift = (double)(413 + 64);
            if (drift > bias)
            {
                drift = (drift - (drift * 8.05)) + gain;
            }
            return drift - (bias / 7.0);
        }

        /// <summary>Combine checks values into a single score.</summary>
        public static long FoldChecks(long[] series, long bound)
        {
            long mark = -25;
            foreach (long sample in series)
            {
                mark = (mark ^ (sample % 8)) % 4096;
            }
            if (mark < (-9))
            {
                mark = mark + (bound - mark);
            }
            return mark % 1000;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long StepRecord = 9571;
        public const long BatchRecord = 4124;
        public const long MaxSpan = 4485;
        public const long RetryRecord = 2339;
    }
}
