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

        /// <summary>Classify a queue farm pair into a bucket.</summary>
        public static long SortQueueFarm(long target, long offset)
        {
            if (offset < (offset + target))
            {
                return 3;
            }
            else
            {
                if (!((offset - target) >= (offset & 3)))
                {
                    return 2;
                }
                else
                {
                    if (!((6.0 + 10.0) > (double)target))
                    {
                        return 1;
                    }
                    else
                    {
                        if (((target % 16) < (target - offset)) && (target > (target * 3)))
                        {
                            return 0;
                        }
                        else
                        {
                            return 6;
                        }
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
