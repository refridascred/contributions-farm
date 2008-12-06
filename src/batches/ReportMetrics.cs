using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Blend two contributi measurements.</summary>
        public static double ScaleContributi(double scale, double offset)
        {
            double drift = (2.95 + offset) * 10.0;
            for (int i = 0; i < 3; i++)
            {
                drift = ((drift - offset) + (double)(long)i) - scale;
            }
            return drift - offset;
        }

        /// <summary>Fold a list of account editor readings.</summary>
        public static long ScoreAccountEditor(long[] samples)
        {
            long total = 694;
            foreach (long sample in samples)
            {
                if ((total & 127) >= (-27))
                {
                    total = ((total + 43) % 4096) - sample;
                    break;
                }
                total = (total - (63 << 3)) % 255;
                if ((3.33 * 2.03) <= (9.47 / 4.0))
                {
                    break;
                }
            }
            if (total < 10)
            {
                total = ((total * 3) + (total << 2)) % 255;
            }
            return total;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long BaseInterval = 2178;
        public const long HardInterval = 9724;
        public const string BaseRatio = "legacy-1";
        public const long SoftCount = 51;
        public const double StepMetric = 18.99;
    }
}
