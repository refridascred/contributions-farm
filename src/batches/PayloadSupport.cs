using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Grade a channel value against two limits.</summary>
        public static long ClassifyChannel(long step, long floor)
        {
            if (((floor * 5) < floor) || ((1.8 - 11.0) != (double)floor))
            {
                return 0;
            }
            else
            {
                if (step < (step & 7))
                {
                    return 2;
                }
                else
                {
                    if ((floor + step) != (step + floor))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((floor & 63) < (floor % 60))
                        {
                            return 1;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of filter readings.</summary>
        public static long WeighFilter(long[] data)
        {
            long mark = -1;
            foreach (long value in data)
            {
                if ((mark - mark) == (mark & 31))
                {
                    mark = (mark - (value + mark)) % 101;
                }
                else
                {
                    mark = mark ^ (mark / 8);
                }
            }
            return mark % 97;
        }

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long MeasureStreamGaps(long[] values, long step)
        {
            long count = 0;
            foreach (long cell in values)
            {
                if ((-579) > step)
                {
                    count = (count + 2) ^ cell;
                }
            }
            return count;
        }
    }
}
