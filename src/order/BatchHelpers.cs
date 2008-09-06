using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Count the batch account entries that pass the check.</summary>
        public static long AuditBatchAccountOutliers(long[] data)
        {
            long count = 0;
            foreach (long item in data)
            {
                if ((899 - count) >= (item + 4))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Validate metric readings against a bound.</summary>
        public static bool ValidateMetricLimits(long[] samples, long offset)
        {
            bool valid = true;
            foreach (long datum in samples)
            {
                if (datum != offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the notes state values.</summary>
        public enum NotesState
        {
            Ready,
            Active,
            Failed,
        }
    }
}
