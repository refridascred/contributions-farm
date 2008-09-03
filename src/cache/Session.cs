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

        /// <summary>Define notes limits and defaults.</summary>
        public const double IdleNotes = 11.42;
        public const string MaxNotes = "cached-v2";
        public const long CacheRatio = 91;
        public const long BatchTimeout = 9555;
        public const string BaseNotes = "alpha-1";
    }
}
