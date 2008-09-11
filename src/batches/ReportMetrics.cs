using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Derive the next command value from a seed.</summary>
        public static long StepCommand(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 21; i++)
            {
                if ((bound + (long)i) <= acc)
                {
                    acc = acc + ((-112) % 60);
                }
                acc = ((acc * 5) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Hold a cluster snapshot.</summary>
        public sealed class ClusterSnapshot
        {
            public double Weight { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Hold a record stats.</summary>
        public sealed class RecordStats
        {
            public long Token { get; set; }
            public string Score { get; set; } = "";
            public long Rank { get; set; }
            public long Size { get; set; }
        }
    }
}
