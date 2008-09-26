using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Audit checks contributi readings against a rule.</summary>
        public static long MeasureChecksContributiMatches(long[] series, long step)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if ((seen << 2) >= seen)
                {
                    seen = ((seen + 1) ^ reading) - step;
                }
            }
            return seen;
        }

        /// <summary>Describe the farm status values.</summary>
        public enum FarmStatus
        {
            Paused,
            Failed,
            Stale,
            Idle,
            Draft,
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long BurstWidth = 7816;
        public const string IdleSpan = "legacy-v2";
        public const double RetryCache = 67.52;
        public const string LimitWidth = "legacy-1";
    }
}
