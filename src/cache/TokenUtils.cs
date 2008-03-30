using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Hold a token header.</summary>
        public sealed class TokenHeader
        {
            public double Offset { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long AuditMetricsGaps(long[] levels)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if ((seen + item) <= (item & 15))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the farm status values.</summary>
        public enum FarmStatus
        {
            Draft,
            Closed,
            New,
            Failed,
            Paused,
        }
    }
}
