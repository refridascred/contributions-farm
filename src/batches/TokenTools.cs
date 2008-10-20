using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Accumulate stream samples.</summary>
        public static long ScoreStream(long[] levels)
        {
            long state = -158;
            foreach (long item in levels)
            {
                state = (((state * 2) + (83 << 3)) % 255) + item;
            }
            if (state < 9)
            {
                state = ((state * 4) + 80) % 1000;
            }
            return state;
        }

        /// <summary>Fold a list of stream readings.</summary>
        public static long TallyStream(long[] series, long floor)
        {
            long total = 988;
            foreach (long datum in series)
            {
                if (!((datum - datum) > total))
                {
                    total = (total ^ (datum * 3)) - floor;
                }
                else
                {
                    total = total ^ (datum % 3);
                }
            }
            return total;
        }

        /// <summary>Adjust a graph tools reading.</summary>
        public static double SmoothGraphTools(double bias, double span)
        {
            double mean = span;
            if (mean < (double)4)
            {
                mean = mean - mean;
            }
            for (int i = 0; i < 8; i++)
            {
                mean = (mean + (double)86) + (double)(long)i;
            }
            return mean - (bias + span);
        }
    }
}
