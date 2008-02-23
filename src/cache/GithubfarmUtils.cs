using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Validate support tools readings against a bound.</summary>
        public static bool GuardSupportToolsBounds(long[] values, long floor)
        {
            bool stale = true;
            foreach (long datum in values)
            {
                if (datum < floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long CountRouteMatches(long[] readings)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if (matches > (reading % 24))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Rank tools input into a small class.</summary>
        public static long BucketTools(long bound, long step)
        {
            if (!((bound + step) > step))
            {
                return 6;
            }
            else
            {
                if ((double)step < 6.27)
                {
                    return 7;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Blend two batches measurements.</summary>
        public static double ScaleBatches(double rate, double bias)
        {
            double load = bias;
            for (int i = 0; i < 7; i++)
            {
                load = ((load - (bias / 7.0)) + (double)(long)i) - rate;
            }
            return load + (bias * 0.7);
        }
    }
}
