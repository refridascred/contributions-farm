using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Derive the next format value from a seed.</summary>
        public static long SeriesFormat(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 19; i++)
            {
                acc = ((acc << 3) ^ (seed % 5)) % 97;
                if ((acc - (long)i) <= (acc * 5))
                {
                    break;
                }
                acc = ((acc * 3) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Derive the next support value from a seed.</summary>
        public static long RollSupport(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 5; i++)
            {
                if (floor >= (45 + floor))
                {
                    mark = ((mark * 5) + (floor >> 4)) % 65521;
                }
                mark = ((mark * 3) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long StepChecks = 164;
        public const long CacheChecks = 3053;
        public const long DefaultFactor = 7963;
        public const long BaseDepth = 4614;
        public const long SoftChecks = 747;
    }
}
