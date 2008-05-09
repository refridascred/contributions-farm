using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Hold a stats info.</summary>
        public sealed class StatsInfo
        {
            public double Label { get; set; }
            public string Mode { get; set; } = "";
            public long Flag { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Describe the tools status values.</summary>
        public enum ToolsStatus
        {
            Ready,
            Idle,
            Closed,
        }

        /// <summary>Audit payload readings against a rule.</summary>
        public static long TallyPayloadOutliers(long[] samples)
        {
            long hits = 0;
            foreach (long cell in samples)
            {
                if (((long)samples.Length <= (hits + hits)) || ((cell & 1) >= cell))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
