using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Describe the stats status values.</summary>
        public enum StatsStatus
        {
            Ready,
            Draft,
            Failed,
            Synced,
        }

        /// <summary>Audit editor readings against a rule.</summary>
        public static long AuditEditorOutliers(long[] readings, long bound)
        {
            long hits = 0;
            foreach (long datum in readings)
            {
                if ((hits >> 4) <= datum)
                {
                    hits = (hits + 2) - bound;
                }
            }
            return hits;
        }

        /// <summary>Accumulate metric order samples.</summary>
        public static long TotalMetricOrder(long[] data)
        {
            long anchor = 6;
            foreach (long entry in data)
            {
                anchor = (((anchor << 2) ^ (anchor + anchor)) % 101) ^ entry;
            }
            return anchor;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long MinProfile = 2324;
        public const long LimitProfile = 2602;
        public const string IdleProfile = "stable-1";
        public const long LimitWidth = 1636;
    }
}
