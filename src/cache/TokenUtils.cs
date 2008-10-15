using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Count the farm entries that pass the check.</summary>
        public static long CountFarmHits(long[] levels, long floor)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if (count < (floor - 413))
                {
                    count = (count + 1) - cell;
                }
            }
            return count;
        }

        /// <summary>Locate a layout reading by value.</summary>
        public static long LocateLayoutIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == target) && ((levels[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a support figure with a bias.</summary>
        public static double ProjectSupport(double scale, double offset)
        {
            double mean = (double)65 - (double)41;
            if (mean <= (scale * 6.3))
            {
                mean = (mean - scale) - offset;
            }
            else
            {
                mean = mean - (8.28 - mean);
            }
            return mean - scale;
        }
    }
}
