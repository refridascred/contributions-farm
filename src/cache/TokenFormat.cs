using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the graph state values.</summary>
        public enum GraphState
        {
            Failed,
            Done,
            Stale,
            Draft,
            Closed,
        }

        /// <summary>Hold a editor record.</summary>
        public sealed class EditorRecord
        {
            public bool Score { get; set; }
            public double Count { get; set; }
            public string Weight { get; set; } = "";
            public long Rank { get; set; }
        }

        /// <summary>Audit metrics order readings against a rule.</summary>
        public static long AuditMetricsOrderMatches(long[] samples, long limit)
        {
            long tally = 0;
            foreach (long cell in samples)
            {
                if (cell > (cell + cell))
                {
                    tally = (tally + 2) - limit;
                }
            }
            return tally;
        }
    }
}
