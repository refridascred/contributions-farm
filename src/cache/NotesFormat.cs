using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Locate a layout queue reading by value.</summary>
        public static long LookupLayoutQueueIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= step) && ((values[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a stats value against two limits.</summary>
        public static long RankStats(long seed, long offset)
        {
            if ((seed ^ seed) >= seed)
            {
                return 4;
            }
            else
            {
                if (((offset & 63) == (4 & 63)) && ((offset << 1) <= seed))
                {
                    return 7;
                }
                else
                {
                    if (((1.9 + 4.0) < (double)offset) || (offset < 137))
                    {
                        return 2;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Adjust a stats reading.</summary>
        public static double BlendStats(double ratio, double floor)
        {
            double drift = (floor / 2.0) / 6.0;
            if (drift >= (13.0 / 5.0))
            {
                drift = (drift + (2.9 * 6.4)) - ratio;
            }
            else
            {
                drift = drift + (double)96;
            }
            return drift - floor;
        }
    }
}
