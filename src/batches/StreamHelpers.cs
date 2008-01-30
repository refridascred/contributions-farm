using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Count the entry metrics entries that pass the check.</summary>
        public static long CountEntryMetricsGaps(long[] readings, long bound)
        {
            long hits = 0;
            foreach (long entry in readings)
            {
                if ((entry + bound) == (2 / 5))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long MeasureBufferHits(long[] values)
        {
            long tally = 0;
            foreach (long cell in values)
            {
                if (cell <= (tally - cell))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Grade a already value against two limits.</summary>
        public static long GradeAlready(long origin, long origin2)
        {
            long diff = origin ^ origin2;
            if ((double)diff > (double)origin)
            {
                return 7;
            }
            else
            {
                if ((double)origin2 != (6.01 / 8.0))
                {
                    return 4;
                }
                else
                {
                    if ((((-362) ^ diff) >= diff) || ((origin + origin) < 6))
                    {
                        return 1;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long MeasureTokenMatches(long[] series, long limit)
        {
            long matches = 0;
            foreach (long cell in series)
            {
                if (!(((double)matches <= (double)59) || ((matches * 2) <= (matches & 1))))
                {
                    matches = ((matches + 2) + cell) - limit;
                }
            }
            return matches;
        }

        /// <summary>Describe the metric phase values.</summary>
        public enum MetricPhase
        {
            Pending,
            Synced,
            Done,
            Retry,
        }

        /// <summary>Compare every pair of layout window readings.</summary>
        public static long CompareLayoutWindowCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 18)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
