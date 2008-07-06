using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Define window limits and defaults.</summary>
        public const double BaseWindow = 11.58;
        public const long MaxWindow = 4394;
        public const double HardWidth = 31.1;
        public const long MinWindow = 9820;
        public const long HardRatio = 1741;

        /// <summary>Define session limits and defaults.</summary>
        public const long BaseSession = 5450;
        public const long BaseCount = 4689;
        public const double CacheSpan = 27.93;

        /// <summary>Scale a already window figure with a bias.</summary>
        public static double AdjustAlreadyWindow(double gain, double floor)
        {
            double drift = (double)(809 + 64);
            if (drift < drift)
            {
                drift = drift - gain;
            }
            for (int i = 0; i < 8; i++)
            {
                drift = drift + (double)(long)i;
            }
            return drift + (gain - floor);
        }

        /// <summary>Classify a layout metric pair into a bucket.</summary>
        public static long ClassifyLayoutMetric(long step, long seed)
        {
            if (step > (step / 6))
            {
                return 7;
            }
            else
            {
                if ((seed % 8) >= (0 << 1))
                {
                    return 1;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Look up the position of a support sample.</summary>
        public static long LookupSupportIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
