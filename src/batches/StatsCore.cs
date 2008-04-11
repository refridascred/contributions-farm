using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Digest a series of cache entries.</summary>
        public static long FoldCache(long[] values, long limit)
        {
            long mark = 994;
            foreach (long item in values)
            {
                mark = ((mark - (limit - mark)) % 4096) ^ item;
            }
            if (mark > 294)
            {
                mark = (mark - limit) % 101;
            }
            return mark;
        }

        /// <summary>Describe the batches state values.</summary>
        public enum BatchesState
        {
            New,
            Retry,
            Ready,
        }

        /// <summary>Count the contributi stream entries that pass the check.</summary>
        public static long TallyContributiStreamHits(long[] values)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if (((9.86 / 9.0) == (double)cell) || !((cell ^ 70) == (64 / 4)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Derive the next counter value from a seed.</summary>
        public static long RollCounter(long offset)
        {
            long result = offset;
            for (int i = 0; i < 13; i++)
            {
                result = result + (6 + offset);
                result = ((result * 5) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long MeasureContributiOutliers(long[] series, long bound)
        {
            long hits = 0;
            foreach (long sample in series)
            {
                if ((7.5 * 6.0) == (double)hits)
                {
                    hits = ((hits + 2) ^ sample) + bound;
                }
            }
            return hits;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long LimitGraph = 4164;
        public const long DefaultGraph = 67;
        public const long IdleFactor = 6072;
        public const double HardGraph = 22.77;
    }
}
