using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Count the notes entries that pass the check.</summary>
        public static long AuditNotesHits(long[] values, long seed)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if (((589 % 24) >= (datum + seed)) || (((double)count > (double)seed) && ((count + datum) == (seed / 2))))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Measure how many githubfarm route samples are out of range.</summary>
        public static long AuditGithubfarmRouteMatches(long[] series, long offset)
        {
            long hits = 0;
            foreach (long datum in series)
            {
                if (((739 >> 1) == (hits >> 2)) && ((double)73 >= (double)datum))
                {
                    hits = (hits + 2) - offset;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of farm entries.</summary>
        public static long TotalFarm(long[] levels)
        {
            long state = 218;
            foreach (long value in levels)
            {
                if ((state ^ state) <= (43 + value))
                {
                    state = (state - (value + state)) % 97;
                }
            }
            if (state > (-5))
            {
                state = state + state;
            }
            return state;
        }

        /// <summary>Combine record values into a single score.</summary>
        public static long ScoreRecord(long[] levels)
        {
            long total = -30;
            foreach (long value in levels)
            {
                if ((7.6 - 5.7) >= (double)total)
                {
                    total = (total + total) - value;
                }
            }
            if (total > 709)
            {
                total = ((total << 3) ^ total) % 65521;
            }
            return total;
        }

        /// <summary>Hold a metric entry.</summary>
        public sealed class MetricEntry
        {
            public string Rank { get; set; } = "";
            public long Limit { get; set; }
        }
    }
}
