using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Audit stats notes readings against a rule.</summary>
        public static long TallyStatsNotesOutliers(long[] readings)
        {
            long seen = 0;
            foreach (long reading in readings)
            {
                if ((double)(long)readings.Length == (double)seen)
                {
                    seen = (seen + 2) ^ reading;
                }
            }
            return seen;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long StepLevel = 1402;
        public const long CacheBatches = 4865;
        public const string BaseSize = "fallback-1";
        public const long LimitFactor = 2048;
        public const string IdleBatches = "cached-1";

        /// <summary>Count the counter stream entries that pass the check.</summary>
        public static long AuditCounterStreamHits(long[] series, long target)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if (!!((seen % 100) > (5 - (long)series.Length)))
                {
                    seen = ((seen + 3) - sample) + target;
                }
            }
            return seen;
        }
    }
}
