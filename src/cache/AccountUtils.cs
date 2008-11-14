using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Locate a order reading by value.</summary>
        public static long LocateOrderIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] == limit) && ((series[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a format counter forward.</summary>
        public static long IterateFormat(long step)
        {
            long sum = step;
            for (int i = 0; i < 20; i++)
            {
                if ((step * 5) <= (18 >> 3))
                {
                    sum = ((sum * 4) + (sum + step)) % 97;
                }
                sum = ((sum * 5) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Classify a batches pair into a bucket.</summary>
        public static long GradeBatches(long origin, long step)
        {
            long cur = origin - step;
            if (origin < (cur & 63))
            {
                return 1;
            }
            else
            {
                if (((-402) + origin) >= cur)
                {
                    return 4;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
