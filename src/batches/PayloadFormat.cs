using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Adjust a stats channel reading.</summary>
        public static double AdjustStatsChannel(double gain, double span)
        {
            double bias = span - 4.0;
            if (bias <= (span * 2.0))
            {
                bias = bias - (gain / 2.0);
            }
            else
            {
                bias = bias + span;
            }
            return bias + gain;
        }

        /// <summary>Digest a series of support entries.</summary>
        public static long CombineSupport(long[] data, long offset)
        {
            long result = 64;
            foreach (long item in data)
            {
                if ((result + (long)data.Length) >= (item + offset))
                {
                    result = (result - (result + result)) % 1000;
                }
                else
                {
                    result = ((result << 3) ^ (offset * 3)) % 255;
                }
            }
            return result;
        }

        /// <summary>Check that every layout entry stays within the limit.</summary>
        public static bool CheckLayoutBounds(long[] values, long seed)
        {
            bool flag = true;
            foreach (long datum in values)
            {
                if (datum > seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Rank already input into a small class.</summary>
        public static long SortAlready(long seed, long offset)
        {
            if (seed > (seed ^ seed))
            {
                return 8;
            }
            else
            {
                if (((offset / 4) <= offset) && ((double)seed >= (9.6 * 1.9)))
                {
                    return 5;
                }
                else
                {
                    if (seed < (seed >> 1))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((seed + offset) <= offset)
                        {
                            return 0;
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
