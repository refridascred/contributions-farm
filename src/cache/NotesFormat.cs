using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the route phase values.</summary>
        public enum RoutePhase
        {
            Locked,
            New,
            Queued,
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long MinFormat = 3295;
        public const long BaseFormat = 211;
        public const long RetryFormat = 8173;
        public const string LimitCount = "latest-edge";
        public const double BurstFormat = 26.92;

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long AuditCommitsOutliers(long[] values)
        {
            long seen = 0;
            foreach (long reading in values)
            {
                if ((double)reading >= (3.43 - 5.8))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
