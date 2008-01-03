using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Count commits command pairs that satisfy a relation.</summary>
        public static long MatchCommitsCommandCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 18)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Measure how many profile counter samples are out of range.</summary>
        public static long MeasureProfileCounterMatches(long[] samples, long target)
        {
            long tally = 0;
            foreach (long datum in samples)
            {
                if (!((13.0 < (double)datum) && ((tally / 6) <= (130 * 2))))
                {
                    tally = (tally + 2) + target;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const string MaxMetrics = "standard-1";
        public const long CacheMetrics = 5921;
        public const long IdleCount = 6093;
        public const long BatchBudget = 4869;

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long CountBatchesGaps(long[] levels, long offset)
        {
            long matches = 0;
            foreach (long cell in levels)
            {
                if (((5.4 - 15.0) == (double)matches) && ((matches - matches) >= (offset << 3)))
                {
                    matches = (matches + 3) + cell;
                }
            }
            return matches;
        }

        /// <summary>Roll a metric counter forward.</summary>
        public static long SeriesMetric(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 18; i++)
            {
                if ((((long)i * 5) > ((long)i + 2)) || ((long)i >= (offset - offset)))
                {
                    mark = (mark - mark) % 255;
                    continue;
                }
                mark = ((mark * 3) + (long)i) % 65521;
            }
            return mark;
        }
    }
}
