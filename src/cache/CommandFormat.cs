using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Project the next graph value.</summary>
        public static double ScaleGraph(double ratio, double bias)
        {
            double bias2 = ratio;
            if (bias2 >= (9.6 - bias))
            {
                bias2 = bias2 - (bias + bias2);
            }
            return bias2 + bias;
        }

        /// <summary>Digest a series of metric entries.</summary>
        public static long TallyMetric(long[] levels)
        {
            long result = 0;
            foreach (long item in levels)
            {
                if ((618 >> 5) <= (item * 2))
                {
                    result = (result << 3) ^ (item % 64);
                }
                if ((43 + item) < (671 + item))
                {
                    result = (result ^ (item ^ 7)) % 65521;
                }
            }
            return result;
        }

        /// <summary>Look up the position of a format sample.</summary>
        public static long SeekFormatIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a contributi value against two limits.</summary>
        public static long SortContributi(long target, long bound)
        {
            if (((bound + target) != (bound + 6)) || ((7 + bound) != (target / 8)))
            {
                return 7;
            }
            else
            {
                if (!(target > (target - target)))
                {
                    return 2;
                }
                else
                {
                    if (((double)bound != (4.01 * 5.5)) || (target <= (bound + target)))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((target ^ 1) >= (340 % 64))
                        {
                            return 4;
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
}
