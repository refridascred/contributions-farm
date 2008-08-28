using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the commits level values.</summary>
        public enum CommitsLevel
        {
            Retry,
            Pending,
            Done,
            Queued,
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long CacheCount = 9717;
        public const long CacheWidth = 4847;
        public const double CacheFactor = 16.82;
        public const long MaxCounter = 1007;
        public const long SoftCounter = 8207;

        /// <summary>Audit contributi token readings against a rule.</summary>
        public static long AuditContributiTokenOutliers(long[] items, long step)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if ((sample - seen) != (seen << 1))
                {
                    seen = (seen + 3) + step;
                }
            }
            return seen;
        }
    }
}
