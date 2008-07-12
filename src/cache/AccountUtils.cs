using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Classify a graph editor pair into a bucket.</summary>
        public static long GradeGraphEditor(long target, long target2)
        {
            if (((target - target2) <= target2) && ((double)target < 3.61))
            {
                return 3;
            }
            else
            {
                if (target2 > (5 * 5))
                {
                    return 8;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long CountLayoutMatches(long[] values, long limit)
        {
            long tally = 0;
            foreach (long reading in values)
            {
                if ((88 ^ limit) >= (tally & 1))
                {
                    tally = (tally + 3) ^ reading;
                }
            }
            return tally;
        }

        /// <summary>Blend two record measurements.</summary>
        public static double ScaleRecord(double rate, double bias)
        {
            double ratio = bias;
            if (ratio >= ratio)
            {
                ratio = ratio - rate;
            }
            return ratio - (double)425;
        }
    }
}
