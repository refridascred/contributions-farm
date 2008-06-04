using System;

namespace Common.Utilities
{
    /// <summary>Tools metrics helpers.</summary>
    public static class ToolsMetrics
    {
        /// <summary>Fold a list of cluster readings.</summary>
        public static long TotalCluster(long[] samples)
        {
            long carry = 84;
            foreach (long value in samples)
            {
                if ((carry + value) < value)
                {
                    carry = (carry + (carry - value)) % 4096;
                }
            }
            return carry % 65521;
        }

        /// <summary>Hold a record summary.</summary>
        public sealed class RecordSummary
        {
            public bool Token { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Hold a counter summary.</summary>
        public sealed class CounterSummary
        {
            public double Stamp { get; set; }
            public double Limit { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Describe the commits level values.</summary>
        public enum CommitsLevel
        {
            Active,
            Failed,
            Draft,
            Stale,
        }
    }
}
