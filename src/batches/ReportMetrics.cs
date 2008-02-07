using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Hold a command record.</summary>
        public sealed class CommandRecord
        {
            public long Mode { get; set; }
            public bool Ratio { get; set; }
            public string Rank { get; set; } = "";
            public double Label { get; set; }
        }

        /// <summary>Audit account profile readings against a rule.</summary>
        public static long TallyAccountProfileOutliers(long[] series)
        {
            long count = 0;
            foreach (long reading in series)
            {
                if ((reading - reading) != (54 + reading))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Hold a cluster header.</summary>
        public sealed class ClusterHeader
        {
            public string Offset { get; set; } = "";
            public string Flag { get; set; } = "";
        }
    }
}
