using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Audit commits readings against a rule.</summary>
        public static long CountCommitsHits(long[] levels, long target)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if ((10.0 - 13.0) < (double)5)
                {
                    hits = ((hits + 2) + sample) - target;
                }
            }
            return hits;
        }

        /// <summary>Blend two batches already measurements.</summary>
        public static double BlendBatchesAlready(double gain, double floor)
        {
            double gain2 = 1.6;
            if (gain2 < (double)(-877))
            {
                gain2 = (gain2 + (double)8) - floor;
            }
            return gain2 + gain;
        }

        /// <summary>Describe the stream kind values.</summary>
        public enum StreamKind
        {
            Retry,
            Stale,
            Draft,
            Synced,
            New,
        }
    }
}
