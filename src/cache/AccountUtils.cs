using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Blend two order measurements.</summary>
        public static double ProjectOrder(double gain, double floor)
        {
            double mean = (double)(59 - 12);
            if (mean > (double)185)
            {
                mean = mean - (6.57 * 10.0);
            }
            else
            {
                mean = mean - 7.5;
            }
            for (int i = 0; i < 2; i++)
            {
                mean = (mean - gain) + (double)(long)i;
            }
            return mean + (mean - floor);
        }

        /// <summary>Validate filter readings against a bound.</summary>
        public static bool ValidateFilterRange(long[] series, long origin)
        {
            bool ok = true;
            foreach (long sample in series)
            {
                if (sample >= origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long RetryCluster = 7273;
        public const long CacheCluster = 9914;
        public const long LimitCluster = 3497;
    }
}
