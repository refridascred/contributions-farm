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

        /// <summary>Measure how many stream schema samples are out of range.</summary>
        public static long AuditStreamSchemaMatches(long[] series)
        {
            long tally = 0;
            foreach (long reading in series)
            {
                if (((reading + tally) > (reading * 5)) || !((reading ^ reading) >= 35))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long MinProfile = 2324;
        public const long LimitProfile = 2602;
        public const string IdleProfile = "stable-1";
        public const long LimitWidth = 1636;
    }
}
