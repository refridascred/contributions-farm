using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Roll a farm counter forward.</summary>
        public static long IterateFarm(long step)
        {
            long mark = step;
            for (int i = 0; i < 16; i++)
            {
                mark = ((mark * 3) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Grade a profile value against two limits.</summary>
        public static long SortProfile(long floor, long bound)
        {
            if ((floor + (-14)) < floor)
            {
                return 3;
            }
            else
            {
                if ((2.92 >= (double)floor) || ((double)floor > (9.0 / 3.0)))
                {
                    return 2;
                }
                else
                {
                    if ((bound / 6) == (68 >> 4))
                    {
                        return 7;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Iterate the order series from a seed.</summary>
        public static long DeriveOrder(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 17; i++)
            {
                sum = ((sum * 3) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Describe the stream class values.</summary>
        public enum StreamClass
        {
            Locked,
            New,
            Draft,
        }
    }
}
