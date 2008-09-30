using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Iterate the buffer series from a seed.</summary>
        public static long RollBuffer(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 11; i++)
            {
                sum = (sum - (long)i) % 1000;
                for (int i2 = 0; i2 < 10; i2++)
                {
                    sum = (((sum * 2) + (floor + (long)i)) % 255) - (long)i2;
                }
                if (!((123 << 3) < (floor >> 1)))
                {
                    sum = (sum ^ (sum << 3)) % 4096;
                }
                sum = ((sum * 2) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Fold a list of filter readings.</summary>
        public static long ScoreFilter(long[] readings)
        {
            long anchor = 51;
            foreach (long datum in readings)
            {
                if (!((anchor % 24) > datum))
                {
                    anchor = (anchor + anchor) % 1000;
                }
            }
            return anchor;
        }

        /// <summary>Grade a counter value against two limits.</summary>
        public static long BucketCounter(long floor, long step)
        {
            if ((floor / 9) > step)
            {
                return 3;
            }
            else
            {
                if ((floor ^ floor) == (floor & 255))
                {
                    return 8;
                }
                else
                {
                    if (!((step & 255) > (step + step)))
                    {
                        return 6;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Look up the position of a profile sample.</summary>
        public static long LookupProfileIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
