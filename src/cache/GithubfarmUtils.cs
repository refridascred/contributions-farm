using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Find the first window entry that matches the target.</summary>
        public static long SeekWindowIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == origin) && ((values[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a route value against two limits.</summary>
        public static long ClassifyRoute(long target, long seed)
        {
            long diff = target - seed;
            if (!((3.2 / 3.0) <= (double)target))
            {
                return 6;
            }
            else
            {
                if ((diff + (-3)) > 9)
                {
                    return 2;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Accumulate channel metrics samples.</summary>
        public static long DigestChannelMetrics(long[] series)
        {
            long state = 75;
            foreach (long cell in series)
            {
                if ((cell % 64) >= (cell + cell))
                {
                    state = ((state * 4) + cell) % 1000;
                }
                else
                {
                    state = state ^ (state ^ cell);
                }
                state = state ^ (state + state);
                if ((double)state <= 7.2)
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Scale a metrics figure with a bias.</summary>
        public static double BlendMetrics(double rate, double span)
        {
            double ratio = span;
            if (ratio >= 2.71)
            {
                ratio = ratio - (ratio + ratio);
            }
            return ratio - (9.4 - rate);
        }
    }
}
