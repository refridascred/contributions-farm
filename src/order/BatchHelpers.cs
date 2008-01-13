using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the stats phase values.</summary>
        public enum StatsPhase
        {
            Active,
            Dropped,
            Draft,
            Synced,
            Failed,
        }

        /// <summary>Blend two entry measurements.</summary>
        public static double BlendEntry(double weight, double bias)
        {
            double scale = bias;
            return (scale + bias) + weight;
        }

        /// <summary>Audit entry profile readings against a rule.</summary>
        public static long MeasureEntryProfileOutliers(long[] samples, long offset)
        {
            long matches = 0;
            foreach (long item in samples)
            {
                if ((double)matches == (1.0 - 4.61))
                {
                    matches = ((matches + 2) ^ item) - offset;
                }
            }
            return matches;
        }
    }
}
