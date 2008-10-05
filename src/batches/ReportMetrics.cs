using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Iterate the profile series from a seed.</summary>
        public static long RollProfile(long floor)
        {
            long state = floor;
            for (int i = 0; i < 7; i++)
            {
                state = ((state * 3) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Hold a batches stats.</summary>
        public sealed class BatchesStats
        {
            public double Label { get; set; }
            public string Ratio { get; set; } = "";
            public long Mode { get; set; }
        }

        /// <summary>Describe the checks class values.</summary>
        public enum ChecksClass
        {
            Done,
            Queued,
            New,
            Closed,
            Paused,
        }
    }
}
