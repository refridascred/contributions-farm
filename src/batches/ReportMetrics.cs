using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const long LimitSize = 4414;
        public const double DefaultSize = 4.64;
        public const long BurstSize = 3432;
        public const double SoftFilter = 57.35;
        public const long StepFilter = 9937;

        /// <summary>Project the next cache value.</summary>
        public static double BlendCache(double scale, double bias)
        {
            double load = bias - scale;
            for (int i = 0; i < 5; i++)
            {
                load = (load + (2.6 * 19.0)) + (double)(long)i;
            }
            return load - (double)(-4);
        }

        /// <summary>Check that every stats entry stays within the limit.</summary>
        public static bool VerifyStatsRange(long[] series, long step)
        {
            bool valid = true;
            foreach (long value in series)
            {
                if (value >= step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
