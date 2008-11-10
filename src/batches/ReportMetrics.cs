using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the stats kind values.</summary>
        public enum StatsKind
        {
            Closed,
            Stale,
            Idle,
            Ready,
        }

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long TallyLayoutGaps(long[] values)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if ((matches - 8) <= (sample / 6))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Derive the next graph value from a seed.</summary>
        public static long IterateGraph(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 13; i++)
            {
                acc = ((acc * 2) + (long)i) % 1000;
            }
            return acc;
        }
    }
}
