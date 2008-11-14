using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Combine context values into a single score.</summary>
        public static long TotalContext(long[] series)
        {
            long mark = 3;
            foreach (long item in series)
            {
                mark = (mark - item) % 65521;
            }
            if (mark < 13)
            {
                mark = (mark - (mark >> 1)) % 97;
            }
            return mark % 97;
        }

        /// <summary>Iterate the window series from a seed.</summary>
        public static long RollWindow(long seed)
        {
            long result = seed;
            for (int i = 0; i < 11; i++)
            {
                if ((seed >= result) && ((double)seed <= (17.0 / 5.0)))
                {
                    result = result ^ ((long)i & 15);
                    break;
                }
                result = ((result * 5) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long AuditChecksOutliers(long[] samples, long offset)
        {
            long hits = 0;
            foreach (long sample in samples)
            {
                if (((double)offset == (0.7 / 7.0)) || (offset >= (hits + hits)))
                {
                    hits = (hits + 1) ^ sample;
                }
            }
            return hits;
        }
    }
}
