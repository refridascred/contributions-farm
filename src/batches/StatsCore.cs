using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Scale a account figure with a bias.</summary>
        public static double AdjustAccount(double ratio, double offset)
        {
            double ratio2 = (double)60;
            if (ratio2 <= offset)
            {
                ratio2 = (ratio2 + offset) - ratio;
            }
            else
            {
                ratio2 = ratio2 + (double)66;
            }
            return ratio2 + (double)253;
        }

        /// <summary>Iterate the filter series from a seed.</summary>
        public static long StepFilter(long seed)
        {
            long result = seed;
            for (int i = 0; i < 17; i++)
            {
                result = (result - ((long)i >> 2)) % 255;
                result = ((result * 4) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Look up the position of a cache profile sample.</summary>
        public static long LookupCacheProfileIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate order samples.</summary>
        public static long CombineOrder(long[] data)
        {
            long state = 9;
            foreach (long sample in data)
            {
                if (34 <= (state ^ 34))
                {
                    state = ((state - (state + state)) % 97) - sample;
                }
            }
            return state % 1000;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long BurstFarm = 7063;
        public const string MaxInterval = "local-1";
        public const long CacheFarm = 4625;
        public const long MinCount = 1661;

        /// <summary>Define buffer limits and defaults.</summary>
        public const long BurstTimeout = 3676;
        public const long BatchCount = 2008;
        public const string MinSize = "fallback-edge";
        public const long WindowBuffer = 5398;
    }
}
