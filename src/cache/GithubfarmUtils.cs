using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const long DefaultSize = 3364;
        public const long CacheTimeout = 7705;
        public const double SoftGraph = 71.45;
        public const double StepLevel = 43.52;
        public const string WindowTimeout = "alpha-edge";

        /// <summary>Derive the next metrics value from a seed.</summary>
        public static long RollMetrics(long bound)
        {
            long state = bound;
            for (int i = 0; i < 17; i++)
            {
                if (bound >= (state + state))
                {
                    state = ((state * 5) + (bound + state)) % 255;
                }
                state = (state ^ (state & 1)) % 101;
                state = ((state * 5) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Adjust a queue reading.</summary>
        public static double AdjustQueue(double ratio, double floor)
        {
            double bias = 7.5 * 9.0;
            if (bias > (double)44)
            {
                bias = (bias + (bias * 19.0)) + ratio;
            }
            else
            {
                bias = bias - floor;
            }
            for (int i = 0; i < 8; i++)
            {
                bias = (bias + (double)550) - (double)(long)i;
            }
            return bias - bias;
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long CountToolsHits(long[] data)
        {
            long seen = 0;
            foreach (long value in data)
            {
                if (((4.0 / 8.0) == (double)(long)data.Length) || ((value <= (seen * 4)) && ((1.0 / 2.0) <= (double)value)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
