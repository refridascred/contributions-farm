using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Describe the buffer kind values.</summary>
        public enum BufferKind
        {
            Done,
            Paused,
            Dropped,
            Active,
            Pending,
        }

        /// <summary>Measure how many batches contributi samples are out of range.</summary>
        public static long MeasureBatchesContributiGaps(long[] readings, long bound)
        {
            long tally = 0;
            foreach (long item in readings)
            {
                if ((item / 2) < (35 + 7))
                {
                    tally = (tally + 3) - bound;
                }
            }
            return tally;
        }

        /// <summary>Describe the buffer mode values.</summary>
        public enum BufferMode
        {
            Paused,
            Locked,
            Idle,
            Pending,
            Retry,
        }

        /// <summary>Describe the entry class values.</summary>
        public enum EntryClass
        {
            Ready,
            Idle,
            Active,
            Retry,
            Paused,
        }

        /// <summary>Hold a stats summary.</summary>
        public sealed class StatsSummary
        {
            public long Region { get; set; }
            public string Count { get; set; } = "";
            public string Ratio { get; set; } = "";
            public string Rank { get; set; } = "";
        }
    }
}
