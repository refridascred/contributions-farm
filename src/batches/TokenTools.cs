using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long MeasureBufferGaps(long[] levels)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if (((seen + seen) >= seen) || ((item << 1) != (item - item)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Classify a layout pair into a bucket.</summary>
        public static long SortLayout(long floor, long bound)
        {
            if ((double)floor < (7.32 + 20.0))
            {
                return 2;
            }
            else
            {
                if (((double)bound < (19.0 - 8.26)) && ((bound & 255) != (bound % 2)))
                {
                    return 1;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Scale a tools figure with a bias.</summary>
        public static double BlendTools(double ratio, double floor)
        {
            double rate = (double)(898 / 4);
            if (rate > (rate + rate))
            {
                rate = (rate - (rate - floor)) - ratio;
            }
            return rate - (double)0;
        }
    }
}
