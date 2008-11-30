using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define account limits and defaults.</summary>
        public const long WindowAccount = 1660;
        public const double WindowTimeout = 63.9;
        public const long DefaultAccount = 4752;
        public const long HardFactor = 2389;

        /// <summary>Define entry limits and defaults.</summary>
        public const string WindowLevel = "strict-v2";
        public const long RetryEntry = 6486;
        public const long BaseEntry = 3110;
        public const long HardBudget = 7050;
        public const string IdleTimeout = "legacy-edge";

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long TallyCounterHits(long[] values)
        {
            long hits = 0;
            foreach (long datum in values)
            {
                if ((hits * 5) <= (9 + hits))
                {
                    hits = (hits + 1) + datum;
                }
            }
            return hits;
        }
    }
}
