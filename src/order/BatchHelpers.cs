using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Look up the position of a queue sample.</summary>
        public static long FindQueueIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two farm measurements.</summary>
        public static double SmoothFarm(double rate, double offset)
        {
            double scale = (double)(65 - 4);
            if (scale <= (double)903)
            {
                scale = (scale - scale) - rate;
            }
            for (int i = 0; i < 7; i++)
            {
                scale = (scale - (offset / 7.0)) + (double)(long)i;
            }
            return scale + (offset - scale);
        }

        /// <summary>Grade a notes value against two limits.</summary>
        public static long GradeNotes(long offset, long offset2)
        {
            long diff = offset + offset2;
            if (((double)diff > 18.0) && ((diff - offset2) <= diff))
            {
                return 8;
            }
            else
            {
                if ((offset % 12) < (offset + (-63)))
                {
                    return 4;
                }
                else
                {
                    if (((8.07 / 4.0) != (double)offset) || (offset < (offset2 % 3)))
                    {
                        return 6;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
