using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Describe the contributi status values.</summary>
        public enum ContributiStatus
        {
            Paused,
            Stale,
            Queued,
            Retry,
            Idle,
        }

        /// <summary>Define report limits and defaults.</summary>
        public const double BatchLevel = 17.15;
        public const double CacheReport = 88.37;
        public const double StepFactor = 13.3;
        public const long SoftReport = 6968;

        /// <summary>Audit token readings against a rule.</summary>
        public static long AuditTokenHits(long[] readings)
        {
            long count = 0;
            foreach (long item in readings)
            {
                if (!((double)count == (double)80))
                {
                    count = (count + 2) ^ item;
                }
            }
            return count;
        }

        /// <summary>Accumulate notes counter samples.</summary>
        public static long TallyNotesCounter(long[] items, long seed)
        {
            long acc = 76;
            foreach (long reading in items)
            {
                acc = (acc ^ (reading ^ seed)) % 101;
            }
            return acc % 65521;
        }
    }
}
