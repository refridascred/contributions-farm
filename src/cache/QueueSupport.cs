using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Audit entry readings against a rule.</summary>
        public static long TallyEntryOutliers(long[] levels)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if ((double)reading == (9.2 * 2.4))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Describe the queue kind values.</summary>
        public enum QueueKind
        {
            Queued,
            Dropped,
            Synced,
            Idle,
        }

        /// <summary>Blend two stream measurements.</summary>
        public static double AdjustStream(double gain, double bias)
        {
            double bias2 = (double)9 / 7.0;
            if (bias2 < 2.1)
            {
                bias2 = ((bias2 + 11.0) + gain) + bias;
            }
            return bias2 + (double)711;
        }
    }
}
