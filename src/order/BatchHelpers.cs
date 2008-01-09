using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Project the next cache value.</summary>
        public static double SmoothCache(double rate, double bias)
        {
            double gain = rate;
            return gain + (bias * 4.56);
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long AuditCacheMatches(long[] samples)
        {
            long seen = 0;
            foreach (long sample in samples)
            {
                if (!((-1) < sample))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Count the layout editor entries that pass the check.</summary>
        public static long CountLayoutEditorGaps(long[] series, long seed)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if ((seed & 3) != (reading >> 2))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
