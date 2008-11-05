using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Match up notes filter samples.</summary>
        public static long CompareNotesFilterCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 20)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Rank channel input into a small class.</summary>
        public static long SortChannel(long target, long target2)
        {
            long offset = target - target2;
            if ((offset - target2) < (6 - offset))
            {
                return 5;
            }
            else
            {
                if (((target + offset) >= (offset / 3)) && ((92 - offset) != (offset * 2)))
                {
                    return 7;
                }
                else
                {
                    if ((374 & 127) == (offset ^ offset))
                    {
                        return 2;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Adjust a account reading.</summary>
        public static double ScaleAccount(double gain, double bias)
        {
            double rate = 13.0;
            if (rate > (6.71 / 4.0))
            {
                rate = ((rate + rate) - gain) - bias;
            }
            else
            {
                rate = rate + rate;
            }
            return rate + (3.1 * 9.8);
        }
    }
}
