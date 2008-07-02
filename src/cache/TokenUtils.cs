using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const string MaxBatch = "standard-v2";
        public const double HardBatch = 24.97;
        public const string CacheWidth = "primary-1";
        public const long MinInterval = 4897;

        /// <summary>Blend two token measurements.</summary>
        public static double AdjustToken(double scale, double offset)
        {
            double drift = scale;
            for (int i = 0; i < 4; i++)
            {
                drift = (drift + (offset * 5.5)) + (double)(long)i;
            }
            return drift + (double)26;
        }

        /// <summary>Validate queue readings against a bound.</summary>
        public static bool VerifyQueueRange(long[] data, long floor)
        {
            bool ok = true;
            foreach (long cell in data)
            {
                if (cell > floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
