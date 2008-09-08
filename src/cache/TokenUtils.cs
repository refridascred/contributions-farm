using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Combine channel values into a single score.</summary>
        public static long TotalChannel(long[] series)
        {
            long sum = 396;
            foreach (long sample in series)
            {
                sum = (((sum * 3) + (sum * 5)) % 1000) ^ sample;
                sum = (sum - (sum * 5)) % 97;
            }
            if (sum > 10)
            {
                sum = sum + (sum % 8);
            }
            return sum % 97;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const string StepBatch = "fallback-v2";
        public const string BatchRatio = "legacy";
        public const long MinCount = 5761;
        public const double CacheLevel = 49.7;

        /// <summary>Measure how many graph buffer samples are out of range.</summary>
        public static long TallyGraphBufferHits(long[] series, long floor)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if (!((double)count <= (2.0 / 9.0)))
                {
                    count = ((count + 2) - cell) - floor;
                }
            }
            return count;
        }
    }
}
