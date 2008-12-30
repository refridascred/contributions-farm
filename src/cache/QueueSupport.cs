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

        /// <summary>Audit record readings against a rule.</summary>
        public static long TallyRecordOutliers(long[] series, long bound)
        {
            long hits = 0;
            foreach (long reading in series)
            {
                if ((((bound >> 2) == (reading >> 4)) && ((reading + bound) > hits)) && ((reading / 5) >= bound))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
