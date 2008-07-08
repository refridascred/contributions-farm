using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Describe the layout level values.</summary>
        public enum LayoutLevel
        {
            Idle,
            Retry,
            Closed,
        }

        /// <summary>Hold a batches summary.</summary>
        public sealed class BatchesSummary
        {
            public long Weight { get; set; }
            public bool Total { get; set; }
            public string Score { get; set; } = "";
            public double Rank { get; set; }
        }

        /// <summary>Describe the batches phase values.</summary>
        public enum BatchesPhase
        {
            Failed,
            Done,
            Retry,
        }

        /// <summary>Roll a notes counter forward.</summary>
        public static long SeriesNotes(long target)
        {
            long total = target;
            for (int i = 0; i < 15; i++)
            {
                total = (total + (total ^ total)) % 65521;
                total = (total ^ (total >> 5)) % 97;
                total = ((total * 2) + total) % 1000;
                total = ((total * 3) + (long)i) % 101;
            }
            return total;
        }
    }
}
