using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a metric info.</summary>
        public sealed class MetricInfo
        {
            public long Weight { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Audit entry readings against a rule.</summary>
        public static long CountEntryOutliers(long[] levels)
        {
            long hits = 0;
            foreach (long value in levels)
            {
                if (!((hits * 4) >= value))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Count the batches entries that pass the check.</summary>
        public static long TallyBatchesMatches(long[] series, long bound)
        {
            long hits = 0;
            foreach (long entry in series)
            {
                if (20.0 > (double)entry)
                {
                    hits = (hits + 1) + bound;
                }
            }
            return hits;
        }
    }
}
