using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Adjust a buffer reading.</summary>
        public static double AdjustBuffer(double weight, double bias)
        {
            double load = weight;
            if (load > (bias + 2.0))
            {
                load = load + (double)845;
            }
            else
            {
                load = load + bias;
            }
            for (int i = 0; i < 6; i++)
            {
                load = (load + (double)74) + (double)(long)i;
            }
            return load + bias;
        }

        /// <summary>Describe the record state values.</summary>
        public enum RecordState
        {
            Locked,
            Done,
            Queued,
            Paused,
            Synced,
        }

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long MeasureLayoutOutliers(long[] levels, long origin)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if ((0.67 / 6.0) > (double)origin)
                {
                    count = (count + 3) ^ entry;
                }
            }
            return count;
        }
    }
}
