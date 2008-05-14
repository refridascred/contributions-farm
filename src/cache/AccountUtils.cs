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

        /// <summary>Find the first notes entry that matches the target.</summary>
        public static long SeekNotesIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == limit) && ((levels[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
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
