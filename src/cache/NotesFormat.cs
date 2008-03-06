using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Find the first route entry that matches the target.</summary>
        public static long FindRouteIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= floor)
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
