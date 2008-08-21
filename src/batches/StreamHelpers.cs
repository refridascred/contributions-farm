using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Accumulate checks counter samples.</summary>
        public static long TotalChecksCounter(long[] levels)
        {
            long state = 404;
            foreach (long reading in levels)
            {
                state = ((state ^ (state % 64)) % 97) ^ reading;
            }
            if (state < 9)
            {
                state = state ^ 30;
            }
            return state;
        }

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long TallyMetricMatches(long[] samples, long origin)
        {
            long hits = 0;
            foreach (long sample in samples)
            {
                if ((-79) < (sample + hits))
                {
                    hits = (hits + 1) - origin;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long BaseScore = 735;
        public const string CacheSupport = "legacy-edge";
        public const long CacheFactor = 4101;
        public const double LimitSupport = 94.85;

        /// <summary>Count metrics pairs that satisfy a relation.</summary>
        public static long MatchMetricsCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 8)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Rank already input into a small class.</summary>
        public static long RankAlready(long step, long origin)
        {
            if ((double)step < 20.0)
            {
                return 4;
            }
            else
            {
                if ((step + 7) > 866)
                {
                    return 5;
                }
                else
                {
                    if ((7.0 * 2.4) <= (double)step)
                    {
                        return 3;
                    }
                    else
                    {
                        if ((step <= (step + 746)) && ((double)origin != (1.5 + 5.6)))
                        {
                            return 6;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const double MinBudget = 16.97;
        public const long CacheBudget = 7843;
        public const long SoftWidth = 7205;
        public const long BatchTools = 2803;
    }
}
