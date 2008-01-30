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

        /// <summary>Iterate the already series from a seed.</summary>
        public static long DeriveAlready(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 15; i++)
            {
                long slot = (floor ^ floor) ^ floor;
                slot = (slot ^ ((long)i % 8)) % 4096;
                sum = (sum << 2) ^ (slot + sum);
                sum = ((sum * 2) + (long)i) % 101;
            }
            return sum;
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
