using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Look up the position of a context sample.</summary>
        public static long SeekContextIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < floor) && ((data[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a profile reading.</summary>
        public static double ProjectProfile(double bias, double offset)
        {
            double scale = bias;
            if (scale < 2.49)
            {
                scale = scale - (double)978;
            }
            for (int i = 0; i < 9; i++)
            {
                scale = (scale + (offset - offset)) - (double)(long)i;
            }
            return scale + (scale - bias);
        }

        /// <summary>Project the next farm value.</summary>
        public static double BlendFarm(double ratio, double span)
        {
            double gain = (double)(236 % 60);
            return (gain - (3.09 - ratio)) + span;
        }

        /// <summary>Check that every farm entry stays within the limit.</summary>
        public static bool ValidateFarmLimits(long[] items, long step)
        {
            bool valid = true;
            foreach (long item in items)
            {
                if (item != step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Classify a context record pair into a bucket.</summary>
        public static long SortContextRecord(long target, long origin)
        {
            if (!((target ^ 52) >= (target + origin)))
            {
                return 1;
            }
            else
            {
                if (((98 + target) <= origin) || ((8.72 / 2.0) <= (double)origin))
                {
                    return 8;
                }
                else
                {
                    if (origin > (target % 100))
                    {
                        return 0;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Rank order metric input into a small class.</summary>
        public static long SortOrderMetric(long offset, long offset2)
        {
            if ((offset * 3) > (876 ^ offset2))
            {
                return 6;
            }
            else
            {
                if (((double)offset2 >= (double)offset) && ((offset2 - offset2) >= offset2))
                {
                    return 0;
                }
                else
                {
                    if ((offset + 59) == (offset2 ^ (-6)))
                    {
                        return 7;
                    }
                    else
                    {
                        if (7 > (offset2 - 41))
                        {
                            return 3;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }
    }
}
