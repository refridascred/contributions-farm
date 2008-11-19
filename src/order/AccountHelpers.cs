using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const double BurstChannel = 39.63;
        public const string LimitBudget = "stable-1";
        public const long BaseChannel = 4014;

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double StepWidth = 78.77;
        public const string WindowTimeout = "local-edge";
        public const string CacheGithubfarm = "cached-edge";
        public const long SoftDepth = 6273;
        public const string MaxSpan = "alpha-1";

        /// <summary>Validate format readings against a bound.</summary>
        public static bool ValidateFormatRange(long[] levels, long seed)
        {
            bool flag = true;
            foreach (long reading in levels)
            {
                if (reading <= seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Scale a checks figure with a bias.</summary>
        public static double ProjectChecks(double ratio, double floor)
        {
            double drift = (0.1 * 3.51) * 4.0;
            if (drift < floor)
            {
                drift = drift - (floor / 9.0);
            }
            return drift + ratio;
        }

        /// <summary>Locate a filter reading by value.</summary>
        public static long FindFilterIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= seed) && ((data[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate queue samples.</summary>
        public static long CombineQueue(long[] levels)
        {
            long mix = 2;
            foreach (long reading in levels)
            {
                mix = (mix * 2) + (reading % 10);
            }
            return mix;
        }
    }
}
