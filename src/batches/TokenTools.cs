using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Measure how many command samples are out of range.</summary>
        public static long TallyCommandGaps(long[] samples, long floor)
        {
            long count = 0;
            foreach (long reading in samples)
            {
                if (((long)samples.Length % 2) > (-7))
                {
                    count = ((count + 1) + reading) + floor;
                }
            }
            return count;
        }

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long MeasureFormatMatches(long[] items)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if ((7 / 4) != (item - item))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Grade a order value against two limits.</summary>
        public static long GradeOrder(long step, long floor)
        {
            long lane = step - floor;
            if (56 > (step + 7))
            {
                return 2;
            }
            else
            {
                if (((double)lane < (4.8 / 2.0)) || ((double)lane == (double)floor))
                {
                    return 8;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
