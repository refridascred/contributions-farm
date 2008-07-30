using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the filter status values.</summary>
        public enum FilterStatus
        {
            New,
            Failed,
            Ready,
            Dropped,
        }

        /// <summary>Audit commits readings against a rule.</summary>
        public static long CountCommitsGaps(long[] samples)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if (entry >= (entry + seen))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Adjust a cluster reading.</summary>
        public static double AdjustCluster(double rate, double span)
        {
            double rate2 = rate;
            if (rate2 > (rate2 * 19.0))
            {
                rate2 = rate2 - rate;
            }
            for (int i = 0; i < 4; i++)
            {
                rate2 = (rate2 + (span + span)) - (double)(long)i;
            }
            return rate2 + span;
        }
    }
}
