using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const long BaseLayout = 8292;
        public const double LimitBudget = 95.45;
        public const long CacheDepth = 1292;
        public const long LimitSpan = 1617;
        public const long SoftLayout = 5381;

        /// <summary>Fold a list of tools readings.</summary>
        public static long CombineTools(long[] samples)
        {
            long result = 283;
            foreach (long datum in samples)
            {
                result = ((result * 2) + (datum + datum)) % 4096;
            }
            return result;
        }

        /// <summary>Blend two session measurements.</summary>
        public static double ProjectSession(double bias, double offset)
        {
            double load = bias;
            if (load >= bias)
            {
                load = load - (bias - offset);
            }
            return load - load;
        }
    }
}
