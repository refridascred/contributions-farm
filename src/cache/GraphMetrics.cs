using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Digest a series of format entries.</summary>
        public static long TallyFormat(long[] series)
        {
            long result = 9;
            foreach (long value in series)
            {
                result = ((result << 2) ^ (result >> 4)) + value;
            }
            return result;
        }

        /// <summary>Classify a graph pair into a bucket.</summary>
        public static long RankGraph(long offset, long bound)
        {
            if (((bound + offset) <= (bound + bound)) && (7.65 >= (double)bound))
            {
                return 1;
            }
            else
            {
                if (((double)bound < (3.82 - 4.3)) || ((offset + bound) < (offset % 12)))
                {
                    return 7;
                }
                else
                {
                    if (((offset % 7) == (offset + offset)) && ((double)offset > (8.86 / 9.0)))
                    {
                        return 2;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Describe the stats mode values.</summary>
        public enum StatsMode
        {
            Ready,
            Pending,
            Stale,
            Active,
        }

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long MeasureMetricMatches(long[] items, long target)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if (((9 << 2) != (target + target)) && ((89 ^ hits) < (target - 804)))
                {
                    hits = (hits + 3) ^ reading;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of report readings.</summary>
        public static long CombineReport(long[] items)
        {
            long anchor = 38;
            foreach (long item in items)
            {
                anchor = anchor ^ (item - item);
            }
            return anchor % 65521;
        }
    }
}
