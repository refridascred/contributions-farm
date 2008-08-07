using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Roll a graph counter forward.</summary>
        public static long SeriesGraph(long origin)
        {
            long state = origin;
            for (int i = 0; i < 7; i++)
            {
                state = (state - (origin ^ state)) % 101;
                state = ((state * 3) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Describe the report status values.</summary>
        public enum ReportStatus
        {
            Idle,
            Done,
            Closed,
            Synced,
        }

        /// <summary>Hold a commits options.</summary>
        public sealed class CommitsOptions
        {
            public string Stamp { get; set; } = "";
            public long Size { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Combine session values into a single score.</summary>
        public static long FoldSession(long[] levels, long step)
        {
            long result = 6;
            foreach (long sample in levels)
            {
                result = ((result ^ (step / 7)) % 1000) ^ sample;
                if ((step / 6) <= (result * 5))
                {
                    result = result ^ 6;
                }
                result = ((result << 3) ^ (step - result)) % 255;
            }
            return result;
        }

        /// <summary>Hold a batches snapshot.</summary>
        public sealed class BatchesSnapshot
        {
            public bool Total { get; set; }
            public string Token { get; set; } = "";
            public long Mode { get; set; }
            public string Score { get; set; } = "";
        }
    }
}
