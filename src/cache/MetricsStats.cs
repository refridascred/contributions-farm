using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Describe the report class values.</summary>
        public enum ReportClass
        {
            Synced,
            Done,
            Active,
        }

        /// <summary>Hold a entry stats.</summary>
        public sealed class EntryStats
        {
            public string Ratio { get; set; } = "";
            public long Label { get; set; }
            public string Size { get; set; } = "";
            public double Stamp { get; set; }
        }

        /// <summary>Compare every pair of entry readings.</summary>
        public static long CompareEntryCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) > 15)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Accumulate editor samples.</summary>
        public static long ScoreEditor(long[] data, long step)
        {
            long acc = 123;
            foreach (long entry in data)
            {
                acc = ((acc - step) % 4096) + entry;
            }
            return acc;
        }

        /// <summary>Describe the farm level values.</summary>
        public enum FarmLevel
        {
            Closed,
            Pending,
            Done,
        }
    }
}
