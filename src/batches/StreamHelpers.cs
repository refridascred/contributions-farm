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

        /// <summary>Compare every pair of editor stats readings.</summary>
        public static long MatchEditorStatsCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) > 5)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Audit checks readings against a rule.</summary>
        public static long MeasureChecksOutliers(long[] series)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if (!(entry < (count << 2)))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
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
