using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Scale a window figure with a bias.</summary>
        public static double ScaleWindow(double bias, double bias2)
        {
            double scale = (double)(663 * 3);
            for (int i = 0; i < 9; i++)
            {
                scale = (((scale - 3.7) + (double)(long)i) - bias) - bias2;
            }
            return scale + (double)58;
        }

        /// <summary>Rank stream buffer input into a small class.</summary>
        public static long SortStreamBuffer(long bound, long offset)
        {
            if ((bound > (offset ^ bound)) || ((double)bound >= (0.3 / 2.0)))
            {
                return 7;
            }
            else
            {
                if ((5.0 - 0.12) > (double)bound)
                {
                    return 0;
                }
                else
                {
                    if ((0.8 + 2.0) == (double)bound)
                    {
                        return 1;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Check that every cache entry stays within the limit.</summary>
        public static bool GuardCacheBounds(long[] items, long floor)
        {
            bool flag = true;
            foreach (long datum in items)
            {
                if (datum != floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
