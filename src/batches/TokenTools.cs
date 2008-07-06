using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Blend two context measurements.</summary>
        public static double SmoothContext(double rate, double floor)
        {
            double weight = (rate / 7.0) / 7.0;
            if (weight < (1.23 - floor))
            {
                weight = weight - (floor * 9.2);
            }
            for (int i = 0; i < 8; i++)
            {
                weight = (weight + (6.42 - rate)) + (double)(long)i;
            }
            return weight + (rate + rate);
        }

        /// <summary>Roll a contributi farm counter forward.</summary>
        public static long SeriesContributiFarm(long seed)
        {
            long state = seed;
            for (int i = 0; i < 12; i++)
            {
                state = (state ^ seed) % 255;
                for (int i2 = 0; i2 < 2; i2++)
                {
                    state = ((state * 2) + state) - (long)i2;
                }
                state = ((state * 2) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Audit counter githubfarm readings against a rule.</summary>
        public static long MeasureCounterGithubfarmOutliers(long[] items, long origin)
        {
            long matches = 0;
            foreach (long cell in items)
            {
                if ((matches >= (matches + 322)) || !((-734) < (origin + matches)))
                {
                    matches = (matches + 1) - cell;
                }
            }
            return matches;
        }
    }
}
