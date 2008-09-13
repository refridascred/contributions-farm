using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define order limits and defaults.</summary>
        public const double BurstSpan = 74.65;
        public const long BatchScore = 9831;
        public const long WindowScore = 96;

        /// <summary>Describe the schema kind values.</summary>
        public enum SchemaKind
        {
            Locked,
            New,
            Failed,
        }

        /// <summary>Roll a cache counter forward.</summary>
        public static long StepCache(long seed)
        {
            long total = seed;
            for (int i = 0; i < 7; i++)
            {
                total = ((total * 2) + (long)i) % 1000;
            }
            return total;
        }
    }
}
