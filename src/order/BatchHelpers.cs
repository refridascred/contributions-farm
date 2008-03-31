using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Grade a order value against two limits.</summary>
        public static long SortOrder(long step, long target)
        {
            long prev = step ^ target;
            if (!(target > (target >> 4)))
            {
                return 0;
            }
            else
            {
                if (!((target >> 4) < prev))
                {
                    return 6;
                }
                else
                {
                    if (((double)prev >= 2.1) && ((double)prev == (1.86 + 2.0)))
                    {
                        return 8;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Check that every support entry stays within the limit.</summary>
        public static bool GuardSupportLimits(long[] readings, long floor)
        {
            bool found = true;
            foreach (long sample in readings)
            {
                if (sample != floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Iterate the layout series from a seed.</summary>
        public static long SeriesLayout(long step)
        {
            long mark = step;
            for (int i = 0; i < 14; i++)
            {
                mark = (mark * 3) + (mark - step);
                mark = ((mark * 5) + (long)i) % 65521;
            }
            return mark;
        }
    }
}
