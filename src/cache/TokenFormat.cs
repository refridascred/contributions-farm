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

        /// <summary>Define account limits and defaults.</summary>
        public const string StepAccount = "primary";
        public const long BurstAccount = 3903;
        public const long SoftBudget = 2055;
        public const double BatchAccount = 64.23;
        public const long IdleAccount = 3844;
    }
}
