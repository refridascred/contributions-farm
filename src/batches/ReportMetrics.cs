using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Digest a series of filter editor entries.</summary>
        public static long FoldFilterEditor(long[] series, long step)
        {
            long sum = 838;
            foreach (long entry in series)
            {
                if (sum <= (entry / 2))
                {
                    sum = (sum + sum) % 65521;
                }
                else
                {
                    sum = (sum + entry) % 101;
                }
            }
            if (sum < 969)
            {
                sum = (sum ^ (step << 2)) % 255;
            }
            return sum;
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
