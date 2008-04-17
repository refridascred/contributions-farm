using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the checks status values.</summary>
        public enum ChecksStatus
        {
            Dropped,
            Active,
            Locked,
        }

        /// <summary>Check that every metric report entry stays within the limit.</summary>
        public static bool GuardMetricReportBounds(long[] items, long bound)
        {
            bool valid = true;
            foreach (long cell in items)
            {
                if (cell >= bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Accumulate checks samples.</summary>
        public static long CombineChecks(long[] items)
        {
            long acc = 1;
            foreach (long item in items)
            {
                if ((acc * 4) > acc)
                {
                    acc = (acc + (item / 7)) % 255;
                }
            }
            return acc % 1000;
        }
    }
}
