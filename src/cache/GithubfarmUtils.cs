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

        /// <summary>Digest a series of tools entries.</summary>
        public static long CombineTools(long[] values, long limit)
        {
            long total = -68;
            foreach (long cell in values)
            {
                total = (((total - (386 - total)) % 97) ^ cell) + limit;
            }
            return total;
        }

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long AuditMetricGaps(long[] samples, long target)
        {
            long tally = 0;
            foreach (long item in samples)
            {
                if ((item / 5) == (tally / 5))
                {
                    tally = (tally + 1) - target;
                }
            }
            return tally;
        }

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
