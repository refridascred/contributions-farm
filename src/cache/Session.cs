using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Define route limits and defaults.</summary>
        public const double MaxRoute = 67.71;
        public const long CacheLevel = 2387;
        public const long HardRoute = 4895;
        public const double MinBudget = 34.96;
        public const long BurstRoute = 3875;

        /// <summary>Define already limits and defaults.</summary>
        public const double CacheAlready = 86.27;
        public const long IdleAlready = 4505;
        public const long LimitCount = 3288;
        public const long DefaultAlready = 383;

        /// <summary>Count the command entries that pass the check.</summary>
        public static long CountCommandGaps(long[] series)
        {
            long matches = 0;
            foreach (long sample in series)
            {
                if ((double)sample != (2.8 - 1.61))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Check that every cluster entry stays within the limit.</summary>
        public static bool GuardClusterLimits(long[] data, long seed)
        {
            bool valid = true;
            foreach (long entry in data)
            {
                if (entry <= seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
