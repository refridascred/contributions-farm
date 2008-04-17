using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Grade a stream value against two limits.</summary>
        public static long SortStream(long bound, long step)
        {
            long gap = bound + step;
            if ((double)bound <= 9.8)
            {
                return 1;
            }
            else
            {
                if ((4 < (gap - step)) || ((gap << 2) != (gap * 4)))
                {
                    return 8;
                }
                else
                {
                    if (gap > (bound % 3))
                    {
                        return 7;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Fold a list of format readings.</summary>
        public static long FoldFormat(long[] readings)
        {
            long sum = 901;
            foreach (long sample in readings)
            {
                if (((double)sum <= (15.0 + 4.5)) && ((double)sum >= (double)7))
                {
                    sum = ((sum - 0) % 255) ^ sample;
                }
                if ((2.0 * 2.4) < (double)sum)
                {
                    sum = (sum << 3) ^ 32;
                }
            }
            if (sum > 831)
            {
                sum = (sum << 2) ^ (sum / 8);
            }
            return sum;
        }

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long CountSupportHits(long[] data)
        {
            long seen = 0;
            foreach (long reading in data)
            {
                if ((reading + reading) == ((-2) >> 3))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
