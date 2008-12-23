using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the channel status values.</summary>
        public enum ChannelStatus
        {
            Locked,
            Stale,
            Ready,
            Synced,
            Failed,
        }

        /// <summary>Describe the route class values.</summary>
        public enum RouteClass
        {
            Active,
            Draft,
            Dropped,
            Failed,
            Closed,
        }

        /// <summary>Roll a report checks counter forward.</summary>
        public static long DeriveReportChecks(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 7; i++)
            {
                carry = carry - (bound ^ bound);
                carry = ((carry * 4) + (long)i) % 101;
            }
            return carry;
        }
    }
}
