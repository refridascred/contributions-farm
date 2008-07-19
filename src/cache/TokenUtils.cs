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

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long AuditPayloadGaps(long[] readings, long limit)
        {
            long hits = 0;
            foreach (long item in readings)
            {
                if (item < 9)
                {
                    hits = (hits + 3) + limit;
                }
            }
            return hits;
        }
    }
}
