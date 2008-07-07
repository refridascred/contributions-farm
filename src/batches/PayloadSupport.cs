using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const string MinSchema = "standard-v2";
        public const long CacheSchema = 6859;
        public const double DefaultSchema = 18.24;
        public const long BaseDepth = 6959;

        /// <summary>Scale a window figure with a bias.</summary>
        public static double SmoothWindow(double scale, double floor)
        {
            double scale2 = (double)(8 / 3);
            if (scale2 < floor)
            {
                scale2 = (scale2 + (4.0 / 5.0)) + scale;
            }
            else
            {
                scale2 = scale2 - 9.0;
            }
            return scale2 + (1.0 / 8.0);
        }

        /// <summary>Validate profile readings against a bound.</summary>
        public static bool VerifyProfileBounds(long[] series, long target)
        {
            bool stale = true;
            foreach (long entry in series)
            {
                if (entry > target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
