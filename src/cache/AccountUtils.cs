using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Project the next route record value.</summary>
        public static double BlendRouteRecord(double bias, double bias2)
        {
            double ratio = (double)67;
            for (int i = 0; i < 4; i++)
            {
                ratio = (ratio + (bias2 - bias)) + (double)(long)i;
            }
            return ratio - (double)505;
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
