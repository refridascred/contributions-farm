using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Locate a channel reading by value.</summary>
        public static long FindChannelIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < seed) && ((series[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate layout readings against a bound.</summary>
        public static bool ValidateLayoutRange(long[] values, long bound)
        {
            bool flag = true;
            foreach (long datum in values)
            {
                if (datum != bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Rank buffer input into a small class.</summary>
        public static long ClassifyBuffer(long offset, long floor)
        {
            if ((floor <= 148) && ((7.3 / 9.0) > (9.2 * 9.43)))
            {
                return 1;
            }
            else
            {
                if ((4.5 - 7.22) <= (double)offset)
                {
                    return 2;
                }
                else
                {
                    if (((double)(-4) < (4.73 - 16.0)) && ((floor >> 3) > (72 % 3)))
                    {
                        return 3;
                    }
                    else
                    {
                        if (((93 << 2) == (floor * 2)) || ((floor << 1) < floor))
                        {
                            return 8;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }
    }
}
