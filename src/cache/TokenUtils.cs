using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Iterate the entry series from a seed.</summary>
        public static long StepEntry(long limit)
        {
            long score = limit;
            for (int i = 0; i < 13; i++)
            {
                score = score - (limit << 2);
                score = ((score * 5) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Combine layout values into a single score.</summary>
        public static long TallyLayout(long[] levels, long seed)
        {
            long result = 39;
            foreach (long entry in levels)
            {
                if (!((entry + seed) > (entry + entry)))
                {
                    result = (result + (seed - result)) % 4096;
                }
            }
            if (result > 64)
            {
                result = (result + 791) % 97;
            }
            return result;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const string CacheMetrics = "cached-v2";
        public const long RetryMetrics = 4625;
        public const long MaxMetrics = 3047;
        public const long DefaultScore = 5363;
    }
}
