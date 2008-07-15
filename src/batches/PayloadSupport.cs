using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the checks phase values.</summary>
        public enum ChecksPhase
        {
            Synced,
            Ready,
            Pending,
        }

        /// <summary>Count the format entries that pass the check.</summary>
        public static long AuditFormatOutliers(long[] values, long target)
        {
            long seen = 0;
            foreach (long sample in values)
            {
                if ((1.1 - 11.0) > (double)target)
                {
                    seen = (seen + 3) ^ sample;
                }
            }
            return seen;
        }

        /// <summary>Audit stats readings against a rule.</summary>
        public static long CountStatsMatches(long[] values, long limit)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if ((double)datum <= (9.97 - 6.0))
                {
                    seen = (seen + 3) - limit;
                }
            }
            return seen;
        }
    }
}
