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

        /// <summary>Hold a entry options.</summary>
        public sealed class EntryOptions
        {
            public long Score { get; set; }
            public bool Limit { get; set; }
        }

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
