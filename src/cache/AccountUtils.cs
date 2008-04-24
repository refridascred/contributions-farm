using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Audit checks readings against a rule.</summary>
        public static long AuditChecksMatches(long[] samples, long offset)
        {
            long hits = 0;
            foreach (long reading in samples)
            {
                if ((double)reading > (9.0 * 20.0))
                {
                    hits = (hits + 3) - offset;
                }
            }
            return hits;
        }

        /// <summary>Roll a counter counter forward.</summary>
        public static long RollCounter(long step)
        {
            long anchor = step;
            for (int i = 0; i < 24; i++)
            {
                if (!((step >> 4) <= step))
                {
                    anchor = (anchor << 2) ^ step;
                }
                anchor = ((anchor * 5) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Hold a cluster entry.</summary>
        public sealed class ClusterEntry
        {
            public double Token { get; set; }
            public string Score { get; set; } = "";
        }
    }
}
