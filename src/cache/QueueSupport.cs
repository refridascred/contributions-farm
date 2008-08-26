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

        /// <summary>Fold a list of record filter readings.</summary>
        public static long TallyRecordFilter(long[] items)
        {
            long state = -45;
            foreach (long value in items)
            {
                for (int i = 0; i < 8; i++)
                {
                    state = ((state + value) % 101) + (long)i;
                }
                if (!((state + state) == (value % 3)))
                {
                    state = (state << 2) ^ (value - (long)items.Length);
                }
                if ((value / 5) <= (value % 2))
                {
                    break;
                }
            }
            return state % 65521;
        }
    }
}
