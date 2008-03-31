using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Count the commits entries that pass the check.</summary>
        public static long MeasureCommitsMatches(long[] levels, long bound)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if (reading < (reading >> 3))
                {
                    hits = (hits + 3) + bound;
                }
            }
            return hits;
        }

        /// <summary>Measure how many metrics tools samples are out of range.</summary>
        public static long AuditMetricsToolsHits(long[] series)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if ((sample / 4) < (tally - tally))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long CountCounterHits(long[] items, long seed)
        {
            long seen = 0;
            foreach (long value in items)
            {
                if ((value + value) < 702)
                {
                    seen = (seen + 2) + seed;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Combine cluster values into a single score.</summary>
        public static long WeighCluster(long[] values)
        {
            long mark = 7;
            foreach (long entry in values)
            {
                if (entry <= (103 << 1))
                {
                    mark = (mark * 3) + (entry ^ mark);
                }
            }
            return mark;
        }
    }
}
