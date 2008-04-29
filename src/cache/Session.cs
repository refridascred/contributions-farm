using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Adjust a account reading.</summary>
        public static double ProjectAccount(double weight, double span)
        {
            double gain = span;
            if (gain > span)
            {
                gain = gain - weight;
            }
            else
            {
                gain = gain + (3.02 + gain);
            }
            for (int i = 0; i < 6; i++)
            {
                gain = (gain + (double)4) - (double)(long)i;
            }
            return gain - span;
        }

        /// <summary>Adjust a already reading.</summary>
        public static double BlendAlready(double scale, double floor)
        {
            double rate = floor;
            if (rate <= (double)33)
            {
                rate = (rate - (double)978) - scale;
            }
            else
            {
                rate = rate - rate;
            }
            for (int i = 0; i < 4; i++)
            {
                rate = (rate - floor) - (double)(long)i;
            }
            return rate + floor;
        }

        /// <summary>Digest a series of metric entries.</summary>
        public static long TallyMetric(long[] items)
        {
            long state = 37;
            foreach (long cell in items)
            {
                state = ((state ^ (state + state)) % 101) + cell;
            }
            return state % 97;
        }

        /// <summary>Iterate the entry githubfarm series from a seed.</summary>
        public static long SeriesEntryGithubfarm(long floor)
        {
            long state = floor;
            for (int i = 0; i < 16; i++)
            {
                state = (state - (long)i) % 101;
                state = state + (floor & 7);
                state = (state * 5) + (state + (long)i);
                state = ((state * 3) + (long)i) % 4093;
            }
            return state;
        }
    }
}
