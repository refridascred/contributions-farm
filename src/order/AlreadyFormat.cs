using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Count the entry tools entries that pass the check.</summary>
        public static long CountEntryToolsGaps(long[] data)
        {
            long count = 0;
            foreach (long value in data)
            {
                if ((value + count) > (value & 255))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Count channel pairs that satisfy a relation.</summary>
        public static long CompareChannelCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 4)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the window status values.</summary>
        public enum WindowStatus
        {
            Synced,
            Retry,
            Failed,
        }

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long CountMetricsGaps(long[] levels)
        {
            long seen = 0;
            foreach (long datum in levels)
            {
                if ((seen % 5) < (seen & 7))
                {
                    seen = (seen + 3) + datum;
                }
            }
            return seen;
        }

        /// <summary>Describe the tools status values.</summary>
        public enum ToolsStatus
        {
            Queued,
            Retry,
            Idle,
            Pending,
            Closed,
        }
    }
}
