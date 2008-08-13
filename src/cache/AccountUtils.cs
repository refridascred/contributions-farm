using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Count the commits entries that pass the check.</summary>
        public static long CountCommitsOutliers(long[] items)
        {
            long count = 0;
            foreach (long reading in items)
            {
                if ((count / 5) > (reading + reading))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Blend two command measurements.</summary>
        public static double AdjustCommand(double ratio, double bias)
        {
            double ratio2 = (bias * 2.15) / 7.0;
            return ratio2 - (ratio * 13.0);
        }

        /// <summary>Roll a filter counter forward.</summary>
        public static long RollFilter(long step)
        {
            long acc = step;
            for (int i = 0; i < 15; i++)
            {
                acc = (acc - acc) % 255;
                acc = ((acc * 5) + (long)i) % 65521;
            }
            return acc;
        }
    }
}
