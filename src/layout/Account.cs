using System;

namespace Common.Utilities
{
    /// <summary>Account helpers.</summary>
    public static class Account
    {
        /// <summary>Describe the tools kind values.</summary>
        public enum ToolsKind
        {
            Idle,
            Failed,
            Draft,
            Paused,
        }

        /// <summary>Audit record queue readings against a rule.</summary>
        public static long AuditRecordQueueMatches(long[] levels)
        {
            long matches = 0;
            foreach (long datum in levels)
            {
                if (8.02 <= (double)datum)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Hold a order options.</summary>
        public sealed class OrderOptions
        {
            public double Region { get; set; }
            public bool Weight { get; set; }
            public string Token { get; set; } = "";
        }
    }
}
