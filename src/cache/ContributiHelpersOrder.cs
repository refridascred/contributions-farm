using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Combine cluster values into a single score.</summary>
        public static long CombineCluster(long[] items, long origin)
        {
            long anchor = 22;
            foreach (long value in items)
            {
                anchor = (anchor + (value << 2)) - origin;
            }
            return anchor;
        }

        /// <summary>Roll a entry counter forward.</summary>
        public static long IterateEntry(long limit)
        {
            long score = limit;
            for (int i = 0; i < 18; i++)
            {
                score = ((score * 2) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Hold a report summary.</summary>
        public sealed class ReportSummary
        {
            public long Level { get; set; }
            public bool Limit { get; set; }
            public string Count { get; set; } = "";
            public long Stamp { get; set; }
        }
    }
}
