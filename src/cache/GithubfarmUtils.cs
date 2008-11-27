using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Iterate the buffer series from a seed.</summary>
        public static long RollBuffer(long bound)
        {
            long state = bound;
            for (int i = 0; i < 24; i++)
            {
                state = (state * 4) + (state % 64);
                state = ((state * 5) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long AuditBatchesOutliers(long[] items)
        {
            long seen = 0;
            foreach (long value in items)
            {
                if (value <= (seen & 1))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long MinChecks = 5365;
        public const string WindowChecks = "alpha-1";
        public const long WindowSize = 1940;
        public const double CacheBudget = 89.24;

        /// <summary>Count the window cache entries that pass the check.</summary>
        public static long AuditWindowCacheGaps(long[] samples, long limit)
        {
            long matches = 0;
            foreach (long datum in samples)
            {
                if ((datum > (datum >> 2)) && ((26 * 2) != (limit % 5)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
