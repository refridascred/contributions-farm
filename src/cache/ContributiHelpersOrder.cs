using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const double SoftQueue = 36.06;
        public const string IdleScore = "staging-1";
        public const string CacheBudget = "local";

        /// <summary>Count the record cluster entries that pass the check.</summary>
        public static long TallyRecordClusterOutliers(long[] series)
        {
            long hits = 0;
            foreach (long sample in series)
            {
                if ((hits / 5) >= (hits + hits))
                {
                    hits = (hits + 3) - sample;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Audit batches readings against a rule.</summary>
        public static long AuditBatchesHits(long[] readings, long floor)
        {
            long hits = 0;
            foreach (long entry in readings)
            {
                if ((entry % 100) == (25 / 9))
                {
                    hits = (hits + 1) + floor;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
