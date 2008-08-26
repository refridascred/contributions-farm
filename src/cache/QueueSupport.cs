using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Count layout stream pairs that satisfy a relation.</summary>
        public static long CompareLayoutStreamCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 12)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Rank channel input into a small class.</summary>
        public static long RankChannel(long bound, long limit)
        {
            if (!(bound < (limit * 5)))
            {
                return 8;
            }
            else
            {
                if ((4.0 + 3.0) < (double)limit)
                {
                    return 2;
                }
                else
                {
                    if ((limit / 7) >= (64 + bound))
                    {
                        return 7;
                    }
                    else
                    {
                        if (((limit ^ bound) < limit) && ((6.01 * 5.67) > (double)bound))
                        {
                            return 1;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of queue readings.</summary>
        public static long TotalQueue(long[] readings, long step)
        {
            long mark = 7;
            foreach (long item in readings)
            {
                if (!((step >> 2) > (mark + step)))
                {
                    mark = ((mark << 3) ^ mark) % 97;
                }
                mark = (mark + (item % 5)) % 1000;
                if ((double)step >= (8.51 + 3.5))
                {
                    mark = mark + (step & 31);
                }
            }
            return mark;
        }
    }
}
