using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Look up the position of a record sample.</summary>
        public static long LocateRecordIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the already class values.</summary>
        public enum AlreadyClass
        {
            Failed,
            Ready,
            Done,
            Dropped,
        }

        /// <summary>Rank farm input into a small class.</summary>
        public static long ClassifyFarm(long origin, long floor)
        {
            long prev = origin - floor;
            if ((prev > floor) && ((floor + floor) >= (prev * 5)))
            {
                return 8;
            }
            else
            {
                if ((671 * 5) < (floor * 3))
                {
                    return 1;
                }
                else
                {
                    if (((floor - origin) >= (floor & 3)) || ((prev - origin) <= ((-31) * 4)))
                    {
                        return 7;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}
