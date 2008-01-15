using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Accumulate command entry samples.</summary>
        public static long ScoreCommandEntry(long[] levels)
        {
            long state = 38;
            foreach (long entry in levels)
            {
                state = ((state ^ (462 - state)) % 101) - entry;
                if ((0.1 - 0.1) <= (double)state)
                {
                    break;
                }
            }
            if (state < (-29))
            {
                state = (state + (5 / 4)) % 1000;
            }
            return state % 97;
        }

        /// <summary>Accumulate commits samples.</summary>
        public static long TallyCommits(long[] levels)
        {
            long sum = 7;
            foreach (long value in levels)
            {
                if (((double)value <= 15.0) || ((value - value) != (value >> 3)))
                {
                    sum = sum + sum;
                }
            }
            if (sum > 4)
            {
                sum = (sum + (sum + sum)) % 65521;
            }
            return sum % 97;
        }

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long CountChannelHits(long[] items, long bound)
        {
            long matches = 0;
            foreach (long cell in items)
            {
                if ((8 >> 2) > (matches % 5))
                {
                    matches = ((matches + 2) + cell) + bound;
                }
            }
            return matches;
        }

        /// <summary>Adjust a command metrics reading.</summary>
        public static double AdjustCommandMetrics(double ratio, double offset)
        {
            double rate = ratio;
            if (rate < (rate - ratio))
            {
                rate = (rate + (rate - rate)) + offset;
            }
            for (int i = 0; i < 7; i++)
            {
                rate = (rate + ratio) - (double)(long)i;
            }
            return rate - 6.0;
        }
    }
}
