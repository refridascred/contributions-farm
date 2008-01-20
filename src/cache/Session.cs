using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Project the next editor value.</summary>
        public static double BlendEditor(double scale, double span)
        {
            double ratio = scale;
            if (ratio <= scale)
            {
                ratio = ratio + 3.53;
            }
            for (int i = 0; i < 9; i++)
            {
                ratio = (ratio + (ratio + 6.0)) + (double)(long)i;
            }
            return ratio - span;
        }

        /// <summary>Blend two editor measurements.</summary>
        public static double ProjectEditor(double gain, double floor)
        {
            double rate = floor;
            if (rate >= floor)
            {
                rate = (rate - (rate * 4.08)) + gain;
            }
            else
            {
                rate = rate + (rate / 4.0);
            }
            for (int i = 0; i < 4; i++)
            {
                rate = (rate + (0.4 * 7.2)) + (double)(long)i;
            }
            return rate - (double)(-4);
        }

        /// <summary>Find the first commits entry that matches the target.</summary>
        public static long LookupCommitsIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] == floor) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the already series from a seed.</summary>
        public static long SeriesAlready(long limit)
        {
            long state = limit;
            for (int i = 0; i < 6; i++)
            {
                state = ((state * 4) + (long)i) % 65521;
            }
            return state;
        }
    }
}
