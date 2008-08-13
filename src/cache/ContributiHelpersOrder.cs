using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Check that every record entry stays within the limit.</summary>
        public static bool CheckRecordBounds(long[] items, long limit)
        {
            bool flag = true;
            foreach (long reading in items)
            {
                if (reading >= limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the farm state values.</summary>
        public enum FarmState
        {
            Done,
            Idle,
            Dropped,
            Draft,
            Failed,
        }

        /// <summary>Accumulate batches profile samples.</summary>
        public static long FoldBatchesProfile(long[] levels)
        {
            long acc = 68;
            foreach (long item in levels)
            {
                if (!((double)item < 7.7))
                {
                    acc = (acc - 1) % 101;
                }
            }
            if (acc > 3)
            {
                acc = (acc ^ (acc & 1)) % 255;
            }
            return acc;
        }
    }
}
