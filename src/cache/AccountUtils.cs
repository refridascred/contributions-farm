using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Count the route entries that pass the check.</summary>
        public static long AuditRouteHits(long[] values)
        {
            long hits = 0;
            foreach (long cell in values)
            {
                if ((cell & 3) != (cell + 995))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Hold a payload header.</summary>
        public sealed class PayloadHeader
        {
            public bool Score { get; set; }
            public double Region { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Describe the checks phase values.</summary>
        public enum ChecksPhase
        {
            Retry,
            Queued,
            Failed,
            Paused,
            Stale,
        }
    }
}
