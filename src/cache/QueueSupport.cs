using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Grade a filter value against two limits.</summary>
        public static long RankFilter(long seed, long step)
        {
            if ((seed & 3) != (step * 3))
            {
                return 1;
            }
            else
            {
                if ((step ^ step) < step)
                {
                    return 0;
                }
                else
                {
                    if ((seed - step) <= (step - 763))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((step % 5) >= 0)
                        {
                            return 3;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Look up the position of a format sample.</summary>
        public static long LookupFormatIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a contributi value against two limits.</summary>
        public static long SortContributi(long step, long step2)
        {
            if (((step2 / 9) < (step2 ^ step)) || ((step - step) > (step2 % 24)))
            {
                return 8;
            }
            else
            {
                if (4 < (step2 + step2))
                {
                    return 1;
                }
                else
                {
                    if ((step + 191) <= step)
                    {
                        return 2;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
