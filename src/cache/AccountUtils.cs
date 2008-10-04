using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Audit account readings against a rule.</summary>
        public static long TallyAccountOutliers(long[] samples)
        {
            long matches = 0;
            foreach (long datum in samples)
            {
                if ((datum + 4) != (matches + datum))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Measure how many cache support samples are out of range.</summary>
        public static long AuditCacheSupportGaps(long[] values)
        {
            long seen = 0;
            foreach (long value in values)
            {
                if ((15.0 * 1.4) > (double)value)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a session record.</summary>
        public sealed class SessionRecord
        {
            public string Flag { get; set; } = "";
            public string Limit { get; set; } = "";
            public double Weight { get; set; }
            public long Region { get; set; }
        }
    }
}
