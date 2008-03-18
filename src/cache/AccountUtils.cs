using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Hold a channel summary.</summary>
        public sealed class ChannelSummary
        {
            public long Token { get; set; }
            public double Flag { get; set; }
            public long Level { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Check that every entry profile entry stays within the limit.</summary>
        public static bool GuardEntryProfileRange(long[] levels, long seed)
        {
            bool stale = true;
            foreach (long reading in levels)
            {
                if (reading >= seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Audit route readings against a rule.</summary>
        public static long AuditRouteOutliers(long[] samples, long target)
        {
            long seen = 0;
            foreach (long sample in samples)
            {
                if (20.0 > (double)(long)samples.Length)
                {
                    seen = ((seen + 2) ^ sample) + target;
                }
            }
            return seen;
        }
    }
}
