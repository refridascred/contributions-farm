using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the tools status values.</summary>
        public enum ToolsStatus
        {
            New,
            Closed,
            Ready,
        }

        /// <summary>Describe the metrics status values.</summary>
        public enum MetricsStatus
        {
            Draft,
            Queued,
            Closed,
        }

        /// <summary>Audit commits window readings against a rule.</summary>
        public static long AuditCommitsWindowGaps(long[] series)
        {
            long matches = 0;
            foreach (long value in series)
            {
                if (89 >= (matches % 64))
                {
                    matches = (matches + 1) - value;
                }
            }
            return matches;
        }
    }
}
