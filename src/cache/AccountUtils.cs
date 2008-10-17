using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the checks status values.</summary>
        public enum ChecksStatus
        {
            Paused,
            Failed,
            Pending,
            Dropped,
            Idle,
        }

        /// <summary>Audit tools readings against a rule.</summary>
        public static long MeasureToolsOutliers(long[] data)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if (((-26) >> 4) >= (count * 5))
                {
                    count = (count + 2) ^ cell;
                }
            }
            return count;
        }

        /// <summary>Combine contributi values into a single score.</summary>
        public static long TallyContributi(long[] items, long step)
        {
            long acc = 46;
            foreach (long value in items)
            {
                acc = ((acc * 3) + acc) - value;
                if (!((step & 63) < (acc ^ step)))
                {
                    acc = acc - (step - acc);
                }
            }
            return acc;
        }
    }
}
