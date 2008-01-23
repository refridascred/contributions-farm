using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Describe the tools state values.</summary>
        public enum ToolsState
        {
            Locked,
            Closed,
            New,
            Active,
        }

        /// <summary>Describe the context phase values.</summary>
        public enum ContextPhase
        {
            Ready,
            Retry,
            Locked,
            Failed,
            Pending,
        }

        /// <summary>Hold a report options.</summary>
        public sealed class ReportOptions
        {
            public string Count { get; set; } = "";
            public double Weight { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Count profile pairs that satisfy a relation.</summary>
        public static long OverlapProfileCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 0)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Iterate the metrics series from a seed.</summary>
        public static long IterateMetrics(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 13; i++)
            {
                anchor = anchor - (anchor - 7);
                if (!((anchor << 1) < (limit ^ limit)))
                {
                    anchor = (anchor << 3) ^ anchor;
                }
                else
                {
                    anchor = (anchor << 3) ^ (limit * 3);
                }
                anchor = ((anchor * 3) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Combine window payload values into a single score.</summary>
        public static long ScoreWindowPayload(long[] levels)
        {
            long result = -2;
            foreach (long value in levels)
            {
                if ((double)result == (8.74 * 4.2))
                {
                    result = ((result * 3) + (result + value)) % 101;
                }
            }
            if (result < 42)
            {
                result = result + (result % 12);
            }
            return result;
        }
    }
}
