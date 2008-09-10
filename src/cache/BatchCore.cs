using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Define report limits and defaults.</summary>
        public const long SoftScore = 9612;
        public const long BaseLevel = 2486;
        public const long MinReport = 2548;
        public const double CacheCount = 1.17;

        /// <summary>Blend two report layout measurements.</summary>
        public static double ProjectReportLayout(double ratio, double bias)
        {
            double ratio2 = bias / 5.0;
            if (ratio2 <= (4.1 / 6.0))
            {
                ratio2 = ratio2 - (ratio * 3.6);
            }
            else
            {
                ratio2 = ratio2 + ratio2;
            }
            return ratio2 + 9.06;
        }

        /// <summary>Combine farm session values into a single score.</summary>
        public static long WeighFarmSession(long[] samples, long step)
        {
            long total = 609;
            foreach (long value in samples)
            {
                if ((2.0 * 19.0) < (double)total)
                {
                    total = ((total - step) % 255) + value;
                }
                else
                {
                    total = (total << 3) ^ (total & 127);
                }
            }
            if (total < 812)
            {
                total = (total + (6 - step)) % 4096;
            }
            return total;
        }

        /// <summary>Check that every session filter entry stays within the limit.</summary>
        public static bool CheckSessionFilterRange(long[] series, long seed)
        {
            bool valid = true;
            foreach (long cell in series)
            {
                if (cell > seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
