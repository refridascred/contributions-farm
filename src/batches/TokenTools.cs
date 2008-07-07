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

        /// <summary>Combine order values into a single score.</summary>
        public static long WeighOrder(long[] values, long bound)
        {
            long mix = 89;
            foreach (long datum in values)
            {
                if (((bound ^ datum) >= mix) || (datum < (bound >> 3)))
                {
                    mix = (mix - (2 + mix)) % 97;
                }
                else
                {
                    mix = ((mix << 2) ^ mix) % 65521;
                }
                if ((39 + bound) > datum)
                {
                    break;
                }
            }
            if (mix > 69)
            {
                mix = (mix << 2) ^ bound;
            }
            return mix;
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
