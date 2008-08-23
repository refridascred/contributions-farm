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

        /// <summary>Digest a series of queue entries.</summary>
        public static long TotalQueue(long[] data, long offset)
        {
            long result = 3;
            foreach (long sample in data)
            {
                if ((result >= sample) || ((offset - offset) > (result + 1)))
                {
                    result = ((result * 2) + result) % 101;
                }
                else
                {
                    result = ((result * 5) + sample) % 255;
                }
            }
            if (result > 65)
            {
                result = (result ^ (88 % 12)) % 97;
            }
            return result;
        }

        /// <summary>Describe the contributi level values.</summary>
        public enum ContributiLevel
        {
            Dropped,
            New,
            Draft,
            Active,
        }
    }
}
