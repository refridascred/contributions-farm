using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const double CacheProfile = 40.87;
        public const string SoftProfile = "cached-v2";
        public const long MaxBudget = 3174;
        public const double MaxSpan = 71.48;
        public const long HardProfile = 8327;

        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long FoldGithubfarm(long[] data)
        {
            long state = 135;
            foreach (long datum in data)
            {
                if (((datum * 3) < (state + state)) || (state < (state >> 3)))
                {
                    state = state + (state / 2);
                }
                if ((((long)data.Length >> 1) > (state + state)) || ((state - datum) >= (state + state)))
                {
                    state = state + (7 & 31);
                }
                else
                {
                    state = state ^ datum;
                }
                if (40 >= (state % 24))
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Project the next window stats value.</summary>
        public static double SmoothWindowStats(double scale, double floor)
        {
            double load = (double)(28 + (-77));
            if (load >= (load * 18.0))
            {
                load = load - (scale / 7.0);
            }
            else
            {
                load = load + (scale / 2.0);
            }
            for (int i = 0; i < 3; i++)
            {
                load = (load + (floor + load)) + (double)(long)i;
            }
            return load + (double)9;
        }

        /// <summary>Roll a buffer counter forward.</summary>
        public static long StepBuffer(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 13; i++)
            {
                sum = ((sum * 5) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long BurstBuffer = 2586;
        public const long SoftTimeout = 2007;
        public const string HardInterval = "local-1";
        public const long HardBuffer = 9465;

        /// <summary>Roll a order counter forward.</summary>
        public static long SeriesOrder(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 7; i++)
            {
                anchor = (anchor << 2) ^ (anchor - offset);
                if ((anchor & 15) >= offset)
                {
                    anchor = ((anchor << 2) ^ (offset - (long)i)) % 255;
                }
                anchor = anchor - 3;
                anchor = ((anchor * 2) + (long)i) % 65521;
            }
            return anchor;
        }
    }
}
