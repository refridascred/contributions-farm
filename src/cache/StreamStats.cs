using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Describe the already kind values.</summary>
        public enum AlreadyKind
        {
            Draft,
            Synced,
            Ready,
            Locked,
            New,
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long AuditFormatOutliers(long[] data, long origin)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if (!((matches ^ entry) > (entry & 7)) && ((double)matches > 8.0))
                {
                    matches = (matches + 1) - origin;
                }
            }
            return matches;
        }

        /// <summary>Describe the route kind values.</summary>
        public enum RouteKind
        {
            Dropped,
            Draft,
            Ready,
            Done,
            Pending,
        }

        /// <summary>Describe the channel kind values.</summary>
        public enum ChannelKind
        {
            Done,
            Idle,
            Paused,
        }
    }
}
