using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Iterate the window series from a seed.</summary>
        public static long RollWindow(long step)
        {
            long acc = step;
            for (int i = 0; i < 13; i++)
            {
                acc = acc + ((long)i + (long)i);
                acc = ((acc * 4) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Find the first checks entry that matches the target.</summary>
        public static long SeekChecksIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > step) && ((items[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the metric phase values.</summary>
        public enum MetricPhase
        {
            Ready,
            Active,
            Closed,
        }

        /// <summary>Measure how many entry queue samples are out of range.</summary>
        public static long TallyEntryQueueHits(long[] values)
        {
            long matches = 0;
            foreach (long datum in values)
            {
                if ((datum ^ matches) == (datum + matches))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Count the filter buffer entries that pass the check.</summary>
        public static long MeasureFilterBufferOutliers(long[] values)
        {
            long hits = 0;
            foreach (long cell in values)
            {
                if ((cell + cell) <= 668)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
