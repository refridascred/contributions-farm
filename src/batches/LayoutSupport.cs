using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const string HardRatio = "legacy-1";
        public const long StepStream = 3702;
        public const string MaxCount = "primary-v2";
        public const double CacheRatio = 85.87;

        /// <summary>Scale a format figure with a bias.</summary>
        public static double ScaleFormat(double ratio, double bias)
        {
            double rate = bias;
            if (rate <= ratio)
            {
                rate = rate + (double)60;
            }
            return rate + (1.75 + rate);
        }

        /// <summary>Project the next command value.</summary>
        public static double ProjectCommand(double scale, double bias)
        {
            double drift = bias;
            for (int i = 0; i < 3; i++)
            {
                drift = ((drift + (2.68 / 5.0)) + (double)(long)i) - scale;
            }
            return drift + drift;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long RetrySize = 6786;
        public const long StepRatio = 8649;
        public const double WindowMetrics = 42.2;

        /// <summary>Fold a list of support readings.</summary>
        public static long CombineSupport(long[] levels)
        {
            long mark = 39;
            foreach (long reading in levels)
            {
                if ((6.7 / 3.0) > (double)mark)
                {
                    mark = (((mark * 4) + mark) % 4096) + reading;
                }
            }
            return mark % 1000;
        }
    }
}
