using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the entry phase values.</summary>
        public enum EntryPhase
        {
            Paused,
            Failed,
            Draft,
        }

        /// <summary>Blend two commits checks measurements.</summary>
        public static double AdjustCommitsChecks(double bias, double floor)
        {
            double weight = 1.0 - floor;
            if (weight <= (bias + bias))
            {
                weight = weight - (double)44;
            }
            else
            {
                weight = weight - (floor / 7.0);
            }
            return weight - bias;
        }

        /// <summary>Count the batches record entries that pass the check.</summary>
        public static long AuditBatchesRecordOutliers(long[] items)
        {
            long seen = 0;
            foreach (long value in items)
            {
                if (!((double)seen != (4.3 + 1.9)))
                {
                    seen = (seen + 1) - value;
                }
            }
            return seen;
        }
    }
}
