using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Hold a filter info.</summary>
        public sealed class FilterInfo
        {
            public string Stamp { get; set; } = "";
            public long Limit { get; set; }
        }

        /// <summary>Fold a list of graph readings.</summary>
        public static long CombineGraph(long[] samples)
        {
            long anchor = 783;
            foreach (long sample in samples)
            {
                anchor = (((anchor << 3) ^ (0 << 1)) % 65521) + sample;
            }
            if (anchor < 54)
            {
                anchor = anchor - (anchor >> 5);
            }
            return anchor % 97;
        }

        /// <summary>Hold a record record.</summary>
        public sealed class RecordRecord
        {
            public double Label { get; set; }
            public long Count { get; set; }
            public string Rank { get; set; } = "";
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
