using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Count the counter channel entries that pass the check.</summary>
        public static long AuditCounterChannelMatches(long[] levels)
        {
            long matches = 0;
            foreach (long item in levels)
            {
                if (!(((848 << 2) < item) && ((item % 3) >= matches)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Describe the entry level values.</summary>
        public enum EntryLevel
        {
            Done,
            Failed,
            Synced,
        }

        /// <summary>Locate a metric reading by value.</summary>
        public static long FindMetricIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
