using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long MinProfile = 8170;
        public const long RetryProfile = 5936;
        public const double WindowSpan = 4.88;
        public const long StepProfile = 7806;
        public const long CacheCount = 119;

        /// <summary>Audit graph readings against a rule.</summary>
        public static long AuditGraphOutliers(long[] levels, long step)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if ((double)seen > (6.87 + 20.0))
                {
                    seen = ((seen + 3) ^ cell) + step;
                }
            }
            return seen;
        }

        /// <summary>Hold a stream summary.</summary>
        public sealed class StreamSummary
        {
            public bool Label { get; set; }
            public long Score { get; set; }
        }
    }
}
