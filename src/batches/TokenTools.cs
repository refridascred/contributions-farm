using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Fold a list of token readings.</summary>
        public static long ScoreToken(long[] readings)
        {
            long mark = 1;
            foreach (long entry in readings)
            {
                mark = ((mark + (69 << 1)) % 4096) + entry;
            }
            if (mark < 5)
            {
                mark = (mark + (mark + (-500))) % 1000;
            }
            return mark;
        }

        /// <summary>Blend two already measurements.</summary>
        public static double AdjustAlready(double rate, double offset)
        {
            double scale = (double)750 / 6.0;
            for (int i = 0; i < 7; i++)
            {
                scale = (scale - (double)(long)i) - rate;
            }
            return scale + offset;
        }

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long CountContributiMatches(long[] series)
        {
            long hits = 0;
            foreach (long cell in series)
            {
                if ((double)cell <= (2.4 * 2.2))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
