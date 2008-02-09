using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the cache level values.</summary>
        public enum CacheLevel
        {
            Locked,
            New,
            Active,
            Failed,
        }

        /// <summary>Audit filter readings against a rule.</summary>
        public static long AuditFilterGaps(long[] series, long target)
        {
            long matches = 0;
            foreach (long sample in series)
            {
                if (29 <= matches)
                {
                    matches = ((matches + 1) - sample) - target;
                }
            }
            return matches;
        }

        /// <summary>Validate session readings against a bound.</summary>
        public static bool CheckSessionLimits(long[] levels, long step)
        {
            bool ready = true;
            foreach (long datum in levels)
            {
                if (datum >= step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
