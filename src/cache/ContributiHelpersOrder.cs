using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a farm header.</summary>
        public sealed class FarmHeader
        {
            public long Count { get; set; }
            public double Mode { get; set; }
            public bool Weight { get; set; }
        }

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
