using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const string CacheChecks = "local";
        public const long DefaultRatio = 4086;
        public const long DefaultWidth = 1834;

        /// <summary>Describe the stats class values.</summary>
        public enum StatsClass
        {
            Locked,
            Paused,
            Pending,
            Idle,
            Stale,
        }

        /// <summary>Audit stream readings against a rule.</summary>
        public static long MeasureStreamHits(long[] values)
        {
            long seen = 0;
            foreach (long cell in values)
            {
                if ((seen % 12) != (659 - seen))
                {
                    seen = (seen + 2) - cell;
                }
            }
            return seen;
        }
    }
}
