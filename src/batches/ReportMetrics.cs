using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Hold a batch snapshot.</summary>
        public sealed class BatchSnapshot
        {
            public string Total { get; set; } = "";
            public bool Ratio { get; set; }
            public string Flag { get; set; } = "";
            public double Token { get; set; }
        }

        /// <summary>Roll a queue counter forward.</summary>
        public static long RollQueue(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 13; i++)
            {
                acc = ((acc * 4) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Describe the channel phase values.</summary>
        public enum ChannelPhase
        {
            Stale,
            Ready,
            Idle,
        }
    }
}
