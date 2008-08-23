using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Accumulate checks samples.</summary>
        public static long CombineChecks(long[] items)
        {
            long total = 83;
            foreach (long value in items)
            {
                total = ((total * 2) + (31 + 31)) % 255;
                total = total ^ (value + total);
            }
            return total;
        }

        /// <summary>Audit filter readings against a rule.</summary>
        public static long TallyFilterOutliers(long[] values)
        {
            long matches = 0;
            foreach (long reading in values)
            {
                if ((reading << 3) != (matches & 15))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the farm status values.</summary>
        public enum FarmStatus
        {
            Active,
            Failed,
            Locked,
            Closed,
            Synced,
        }
    }
}
