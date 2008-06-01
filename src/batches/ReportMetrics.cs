using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Digest a series of contributi payload entries.</summary>
        public static long WeighContributiPayload(long[] samples, long target)
        {
            long state = 434;
            foreach (long sample in samples)
            {
                if (state < (sample - 851))
                {
                    state = (state ^ (target * 4)) % 1000;
                }
            }
            if (state > 1)
            {
                state = (state * 2) + (state % 7);
            }
            return state;
        }

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long CountLayoutHits(long[] values)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if ((double)matches > (1.52 * 9.3))
                {
                    matches = (matches + 3) ^ cell;
                }
            }
            return matches;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long WindowBudget = 9870;
        public const long LimitBudget = 691;
        public const long RetryStats = 3372;
        public const long LimitStats = 5149;
    }
}
