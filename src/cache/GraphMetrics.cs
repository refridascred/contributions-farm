using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Locate a batches reading by value.</summary>
        public static long LookupBatchesIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the window state values.</summary>
        public enum WindowState
        {
            Locked,
            Ready,
            Done,
            Queued,
        }

        /// <summary>Audit tools readings against a rule.</summary>
        public static long MeasureToolsMatches(long[] items)
        {
            long matches = 0;
            foreach (long item in items)
            {
                if ((matches >> 1) <= (item - (long)items.Length))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the tools phase values.</summary>
        public enum ToolsPhase
        {
            Ready,
            New,
            Failed,
            Paused,
            Active,
        }

        /// <summary>Derive the next session metric value from a seed.</summary>
        public static long SeriesSessionMetric(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 9; i++)
            {
                mark = (mark + ((long)i * 5)) % 97;
                mark = ((mark * 5) + (long)i) % 101;
            }
            return mark;
        }
    }
}
