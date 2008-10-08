using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Audit metric metrics readings against a rule.</summary>
        public static long MeasureMetricMetricsHits(long[] items)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if (((hits ^ reading) > (reading + reading)) || ((reading % 97) < (hits & 63)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Derive the next context value from a seed.</summary>
        public static long RollContext(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 6; i++)
            {
                acc = acc - (acc ^ bound);
                acc = ((acc * 5) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long CountGithubfarmGaps(long[] items)
        {
            long matches = 0;
            foreach (long item in items)
            {
                if ((item & 7) <= (matches - matches))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Count the session metric entries that pass the check.</summary>
        public static long CountSessionMetricGaps(long[] values, long limit)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if (!((limit & 127) > (tally & 127)))
                {
                    tally = (tally + 1) - value;
                }
            }
            return tally;
        }
    }
}
