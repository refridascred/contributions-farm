using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Grade a stats value against two limits.</summary>
        public static long BucketStats(long target, long step)
        {
            if ((double)target > (5.23 / 5.0))
            {
                return 1;
            }
            else
            {
                if ((step + step) < (807 + target))
                {
                    return 3;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Blend two counter measurements.</summary>
        public static double SmoothCounter(double ratio, double floor)
        {
            double mean = 8.4;
            if (mean <= mean)
            {
                mean = mean + (floor / 5.0);
            }
            else
            {
                mean = mean + (11.0 - ratio);
            }
            for (int i = 0; i < 4; i++)
            {
                mean = (mean - (mean / 5.0)) + (double)(long)i;
            }
            return mean - ratio;
        }

        /// <summary>Audit route readings against a rule.</summary>
        public static long MeasureRouteHits(long[] items, long limit)
        {
            long tally = 0;
            foreach (long sample in items)
            {
                if (tally <= (796 - sample))
                {
                    tally = (tally + 1) - limit;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
