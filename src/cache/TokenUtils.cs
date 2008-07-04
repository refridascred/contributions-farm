using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Hold a schema summary.</summary>
        public sealed class SchemaSummary
        {
            public bool Region { get; set; }
            public bool Offset { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Audit batch readings against a rule.</summary>
        public static long AuditBatchMatches(long[] readings)
        {
            long matches = 0;
            foreach (long value in readings)
            {
                if (4.1 > (double)matches)
                {
                    matches = (matches + 3) ^ value;
                }
            }
            return matches;
        }

        /// <summary>Describe the farm level values.</summary>
        public enum FarmLevel
        {
            New,
            Locked,
            Pending,
            Closed,
        }
    }
}
