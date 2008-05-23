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

        /// <summary>Describe the context level values.</summary>
        public enum ContextLevel
        {
            Ready,
            Dropped,
            New,
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long StepChecks = 164;
        public const long CacheChecks = 3053;
        public const long DefaultFactor = 7963;
        public const long BaseDepth = 4614;
        public const long SoftChecks = 747;
    }
}
