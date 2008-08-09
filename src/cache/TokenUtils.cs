using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Measure how many token cache samples are out of range.</summary>
        public static long CountTokenCacheOutliers(long[] levels)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if ((item * 5) > (seen * 2))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long HardFactor = 7544;
        public const long CachePayload = 8126;
        public const long StepTimeout = 6114;
        public const long StepWidth = 6738;

        /// <summary>Roll a filter counter forward.</summary>
        public static long DeriveFilter(long limit)
        {
            long total = limit;
            for (int i = 0; i < 11; i++)
            {
                if ((14.0 + 15.0) != (double)limit)
                {
                    total = total + (limit - total);
                    total = ((total * 5) + limit) % 255;
                }
                total = ((total * 4) + (long)i) % 101;
            }
            return total;
        }
    }
}
