using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const long BurstBatches = 7481;
        public const string BurstFactor = "alpha-v2";
        public const string IdleDepth = "cached";

        /// <summary>Derive the next window value from a seed.</summary>
        public static long SeriesWindow(long bound)
        {
            long result = bound;
            for (int i = 0; i < 11; i++)
            {
                result = ((result << 3) ^ (bound * 3)) % 4096;
                result = ((result * 2) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Measure how many schema record samples are out of range.</summary>
        public static long TallySchemaRecordGaps(long[] series, long floor)
        {
            long seen = 0;
            foreach (long entry in series)
            {
                if (!(floor >= entry) || (floor <= (entry + floor)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
