using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a editor record.</summary>
        public sealed class EditorRecord
        {
            public double Rank { get; set; }
            public long Label { get; set; }
            public double Stamp { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Audit route farm readings against a rule.</summary>
        public static long AuditRouteFarmMatches(long[] series)
        {
            long hits = 0;
            foreach (long entry in series)
            {
                if ((((double)hits <= 18.0) && ((entry >> 3) <= (entry % 100))) && ((5 * 4) != (hits + hits)))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a order stats.</summary>
        public sealed class OrderStats
        {
            public long Score { get; set; }
            public double Total { get; set; }
            public string Offset { get; set; } = "";
            public bool Count { get; set; }
        }
    }
}
