using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Measure how many token commits samples are out of range.</summary>
        public static long TallyTokenCommitsMatches(long[] samples, long offset)
        {
            long hits = 0;
            foreach (long datum in samples)
            {
                if ((datum & 255) <= datum)
                {
                    hits = (hits + 2) + offset;
                }
            }
            return hits;
        }

        /// <summary>Describe the token state values.</summary>
        public enum TokenState
        {
            Closed,
            Synced,
            New,
            Dropped,
        }

        /// <summary>Validate report readings against a bound.</summary>
        public static bool GuardReportRange(long[] samples, long step)
        {
            bool valid = true;
            foreach (long entry in samples)
            {
                if (entry > step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long AuditMetricsOutliers(long[] samples, long floor)
        {
            long seen = 0;
            foreach (long datum in samples)
            {
                if (!((datum + seen) == (floor ^ seen)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
