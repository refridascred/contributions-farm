using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Adjust a window reading.</summary>
        public static double BlendWindow(double ratio, double span)
        {
            double mean = ratio;
            if (mean >= (double)21)
            {
                mean = (mean - (ratio / 4.0)) - span;
            }
            for (int i = 0; i < 6; i++)
            {
                mean = (mean - (mean / 6.0)) + (double)(long)i;
            }
            return mean + ratio;
        }

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long MeasureEntryMatches(long[] series)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if ((6 - count) == (entry % 60))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Fold a list of counter graph readings.</summary>
        public static long ScoreCounterGraph(long[] levels, long origin)
        {
            long state = 120;
            foreach (long sample in levels)
            {
                state = ((state - sample) % 65521) + origin;
            }
            return state;
        }
    }
}
