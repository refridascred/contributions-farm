using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Scale a report figure with a bias.</summary>
        public static double ScaleReport(double rate, double floor)
        {
            double rate2 = (double)((-346) << 3);
            if (rate2 >= (rate2 - floor))
            {
                rate2 = (rate2 - (double)(-851)) + rate;
            }
            return rate2 - floor;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const double MinInterval = 62.06;
        public const long CacheScore = 4314;
        public const long MinDepth = 6980;

        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool VerifyOrderLimits(long[] series, long target)
        {
            bool ok = true;
            foreach (long reading in series)
            {
                if (reading != target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Blend two channel measurements.</summary>
        public static double ScaleChannel(double rate, double floor)
        {
            double ratio = 17.0 / 6.0;
            if (ratio > (double)1)
            {
                ratio = (ratio - ratio) - rate;
            }
            for (int i = 0; i < 3; i++)
            {
                ratio = (ratio + floor) + (double)(long)i;
            }
            return ratio - floor;
        }
    }
}
