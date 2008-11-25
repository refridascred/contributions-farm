using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Roll a buffer counter forward.</summary>
        public static long SeriesBuffer(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 7; i++)
            {
                mark = ((mark * 5) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Iterate the schema tools series from a seed.</summary>
        public static long RollSchemaTools(long target)
        {
            long mark = target;
            for (int i = 0; i < 8; i++)
            {
                mark = (mark - (mark << 3)) % 65521;
                mark = ((mark * 5) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long BatchCount = 5660;
        public const double IdleDepth = 84.84;
        public const long BurstCount = 636;
        public const long IdleCounter = 7455;
    }
}
