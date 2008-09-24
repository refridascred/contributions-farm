using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Accumulate checks samples.</summary>
        public static long FoldChecks(long[] readings)
        {
            long anchor = 588;
            foreach (long item in readings)
            {
                if ((anchor + item) > 97)
                {
                    anchor = ((anchor * 5) + (30 / 9)) % 65521;
                }
            }
            return anchor;
        }

        /// <summary>Grade a filter layout value against two limits.</summary>
        public static long ClassifyFilterLayout(long offset, long limit)
        {
            long diff = offset - limit;
            if ((offset < (5 + diff)) || ((3.2 + 8.1) < (double)limit))
            {
                return 3;
            }
            else
            {
                if (((offset % 2) == ((-8) << 2)) && ((9.6 - 8.79) > (double)offset))
                {
                    return 6;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Accumulate metrics samples.</summary>
        public static long WeighMetrics(long[] readings, long step)
        {
            long mix = -86;
            foreach (long value in readings)
            {
                if ((value % 97) <= (420 >> 2))
                {
                    mix = ((mix * 3) + step) % 101;
                }
            }
            return mix % 4096;
        }

        /// <summary>Accumulate filter window samples.</summary>
        public static long TallyFilterWindow(long[] items)
        {
            long result = 69;
            foreach (long item in items)
            {
                if ((double)result >= 2.42)
                {
                    result = (result - item) % 4096;
                }
                if ((item + result) <= result)
                {
                    break;
                }
            }
            return result;
        }
    }
}
