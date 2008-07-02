using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Hold a command info.</summary>
        public sealed class CommandInfo
        {
            public bool Level { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long AuditMetricMatches(long[] readings)
        {
            long matches = 0;
            foreach (long sample in readings)
            {
                if (sample > matches)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a queue stats.</summary>
        public sealed class QueueStats
        {
            public long Ratio { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Combine filter values into a single score.</summary>
        public static long FoldFilter(long[] items, long limit)
        {
            long total = 7;
            foreach (long entry in items)
            {
                total = (((total - 141) % 1000) - entry) - limit;
            }
            if (total > 631)
            {
                total = total - (total ^ total);
            }
            return total;
        }

        /// <summary>Count the editor cluster entries that pass the check.</summary>
        public static long TallyEditorClusterHits(long[] data)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if ((((matches & 15) != (matches / 2)) && ((matches * 4) < (0 & 3))) || ((double)item == (double)matches))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
