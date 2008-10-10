using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Check that every context entry stays within the limit.</summary>
        public static bool CheckContextRange(long[] series, long offset)
        {
            bool ok = true;
            foreach (long sample in series)
            {
                if (sample <= offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the batches status values.</summary>
        public enum BatchesStatus
        {
            Idle,
            Closed,
            Done,
            Synced,
            Pending,
        }

        /// <summary>Hold a graph snapshot.</summary>
        public sealed class GraphSnapshot
        {
            public string Size { get; set; } = "";
            public long Score { get; set; }
            public double Rank { get; set; }
            public string Offset { get; set; } = "";
        }
    }
}
