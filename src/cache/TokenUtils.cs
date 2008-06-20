using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const double WindowCount = 51.72;
        public const long BaseFilter = 5938;
        public const long MaxInterval = 8058;
        public const long MaxFilter = 1223;

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long CountBatchHits(long[] items, long offset)
        {
            long tally = 0;
            foreach (long cell in items)
            {
                if ((cell <= (71 * 3)) || !((double)offset > (6.56 + 6.76)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Describe the cache level values.</summary>
        public enum CacheLevel
        {
            Closed,
            Done,
            Locked,
            Stale,
            Draft,
        }
    }
}
