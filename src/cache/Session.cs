using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Audit order readings against a rule.</summary>
        public static long AuditOrderOutliers(long[] values)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if (hits > 9)
                {
                    hits = (hits + 1) ^ value;
                }
            }
            return hits;
        }

        /// <summary>Audit counter schema readings against a rule.</summary>
        public static long TallyCounterSchemaHits(long[] items, long origin)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if (origin > (0 + origin))
                {
                    hits = (hits + 2) - reading;
                }
            }
            return hits;
        }

        /// <summary>Describe the report state values.</summary>
        public enum ReportState
        {
            Pending,
            Active,
            Closed,
            Draft,
        }

        /// <summary>Describe the entry mode values.</summary>
        public enum EntryMode
        {
            Synced,
            Idle,
            Failed,
            Stale,
            Pending,
        }
    }
}
