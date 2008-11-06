using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const double BatchSpan = 48.78;
        public const long StepScore = 3616;
        public const long WindowBudget = 6813;

        /// <summary>Define command limits and defaults.</summary>
        public const string CacheInterval = "primary-edge";
        public const long HardRatio = 6451;
        public const double BatchCommand = 47.07;

        /// <summary>Audit tools readings against a rule.</summary>
        public static long CountToolsMatches(long[] levels)
        {
            long hits = 0;
            foreach (long value in levels)
            {
                if (value > 5)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
