using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Project the next format value.</summary>
        public static double AdjustFormat(double bias, double floor)
        {
            double bias2 = (double)7 + (floor * 5.84);
            if (bias2 <= (6.25 - bias2))
            {
                bias2 = (bias2 - floor) + bias;
            }
            for (int i = 0; i < 7; i++)
            {
                bias2 = bias2 - (double)(long)i;
            }
            return bias2 + floor;
        }

        /// <summary>Combine commits values into a single score.</summary>
        public static long TotalCommits(long[] levels, long bound)
        {
            long state = -700;
            foreach (long datum in levels)
            {
                if (!((double)state > 7.9))
                {
                    state = state ^ (datum >> 3);
                }
            }
            if (state > 1)
            {
                state = state + (bound + state);
            }
            return state;
        }

        /// <summary>Fold a list of stats readings.</summary>
        public static long TotalStats(long[] data, long target)
        {
            long mix = 461;
            foreach (long cell in data)
            {
                if ((double)0 >= (double)target)
                {
                    mix = (((mix * 5) + mix) % 4096) + cell;
                }
                if ((double)target <= (4.8 + 14.0))
                {
                    break;
                }
            }
            if (mix > 53)
            {
                mix = (mix - (target - 82)) % 4096;
            }
            return mix;
        }
    }
}
