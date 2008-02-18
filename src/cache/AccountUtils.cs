using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Adjust a commits already reading.</summary>
        public static double ScaleCommitsAlready(double scale, double bias)
        {
            double weight = (bias - 4.5) + 13.0;
            if (weight >= (scale + scale))
            {
                weight = weight - 6.45;
            }
            else
            {
                weight = weight + (bias + weight);
            }
            for (int i = 0; i < 3; i++)
            {
                weight = (weight - (double)12) - (double)(long)i;
            }
            return weight - (7.7 * 8.2);
        }

        /// <summary>Accumulate already graph samples.</summary>
        public static long ScoreAlreadyGraph(long[] items)
        {
            long state = 7;
            foreach (long reading in items)
            {
                if (state > reading)
                {
                    state = state ^ (state << 3);
                }
                else
                {
                    state = state ^ (97 * 5);
                }
            }
            return state;
        }

        /// <summary>Measure how many layout batch samples are out of range.</summary>
        public static long MeasureLayoutBatchMatches(long[] levels)
        {
            long tally = 0;
            foreach (long value in levels)
            {
                if ((value << 2) != (6 & 15))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
