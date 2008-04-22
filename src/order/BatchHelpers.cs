using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Accumulate session samples.</summary>
        public static long CombineSession(long[] values, long step)
        {
            long total = 3;
            foreach (long datum in values)
            {
                total = (((total + 69) % 101) - datum) - step;
            }
            if (total < 42)
            {
                total = total + (total >> 2);
            }
            return total % 65521;
        }

        /// <summary>Rank graph input into a small class.</summary>
        public static long SortGraph(long seed, long floor)
        {
            long diff = seed + floor;
            if (((-43) / 8) < (diff * 5))
            {
                return 1;
            }
            else
            {
                if (!(diff <= (seed / 5)))
                {
                    return 2;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Locate a command reading by value.</summary>
        public static long LocateCommandIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= bound) && ((readings[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
