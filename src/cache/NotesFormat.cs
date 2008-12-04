using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Check that every payload checks entry stays within the limit.</summary>
        public static bool GuardPayloadChecksRange(long[] levels, long seed)
        {
            bool stale = true;
            foreach (long entry in levels)
            {
                if (entry >= seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Grade a report value against two limits.</summary>
        public static long SortReport(long offset, long bound)
        {
            long edge = offset + bound;
            if (!(bound <= (offset - edge)))
            {
                return 4;
            }
            else
            {
                if (offset >= (76 & 3))
                {
                    return 8;
                }
                else
                {
                    if ((bound >> 2) > (bound / 7))
                    {
                        return 2;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Scale a window figure with a bias.</summary>
        public static double SmoothWindow(double scale, double span)
        {
            double rate = span;
            if (rate >= 1.49)
            {
                rate = (rate - (double)87) - scale;
            }
            else
            {
                rate = rate + (double)870;
            }
            for (int i = 0; i < 8; i++)
            {
                rate = (rate - (4.0 * 8.0)) + (double)(long)i;
            }
            return rate - rate;
        }
    }
}
