using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the batch mode values.</summary>
        public enum BatchMode
        {
            Ready,
            New,
            Paused,
        }

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long TallyEntryHits(long[] values, long target)
        {
            long seen = 0;
            foreach (long cell in values)
            {
                if (cell < seen)
                {
                    seen = (seen + 1) + target;
                }
            }
            return seen;
        }

        /// <summary>Check that every metrics record entry stays within the limit.</summary>
        public static bool ValidateMetricsRecordLimits(long[] levels, long target)
        {
            bool flag = true;
            foreach (long entry in levels)
            {
                if (entry <= target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
