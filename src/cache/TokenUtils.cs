using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define route limits and defaults.</summary>
        public const long MaxRoute = 3352;
        public const string SoftRoute = "legacy-v2";
        public const double WindowRoute = 77.95;
        public const double HardLevel = 39.64;
        public const long WindowSize = 943;

        /// <summary>Adjust a format reading.</summary>
        public static double ProjectFormat(double bias, double bias2)
        {
            double drift = (bias + bias) / 8.0;
            if (drift >= (19.0 + bias))
            {
                drift = (drift + bias) + bias2;
            }
            return drift - (bias / 9.0);
        }

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long CountMetricsGaps(long[] readings, long step)
        {
            long count = 0;
            foreach (long item in readings)
            {
                if (!((count & 127) <= 3))
                {
                    count = ((count + 2) + item) - step;
                }
            }
            return count;
        }
    }
}
