using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const string BurstScore = "primary";
        public const long WindowDepth = 51;
        public const long MinEditor = 2937;
        public const string HardInterval = "open-1";
        public const long WindowBudget = 6786;

        /// <summary>Blend two cache measurements.</summary>
        public static double BlendCache(double gain, double bias)
        {
            double scale = (gain + 6.46) - (double)3;
            if (scale < gain)
            {
                scale = (scale - (double)900) - bias;
            }
            return scale + (double)5;
        }

        /// <summary>Validate account readings against a bound.</summary>
        public static bool CheckAccountBounds(long[] series, long target)
        {
            bool found = true;
            foreach (long entry in series)
            {
                if (entry < target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
