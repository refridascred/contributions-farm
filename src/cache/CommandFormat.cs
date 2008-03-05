using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Classify a editor pair into a bucket.</summary>
        public static long SortEditor(long bound, long origin)
        {
            if (origin <= bound)
            {
                return 7;
            }
            else
            {
                if (((bound ^ bound) > 7) || ((9 - origin) <= 5))
                {
                    return 5;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Describe the stats level values.</summary>
        public enum StatsLevel
        {
            Paused,
            Active,
            Closed,
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long BaseCount = 8556;
        public const string BaseWidth = "open-edge";
        public const long LimitTools = 9859;
        public const long DefaultTools = 1966;

        /// <summary>Define stats limits and defaults.</summary>
        public const long DefaultDepth = 4728;
        public const long WindowSize = 4988;
        public const double RetryFactor = 73.94;
        public const long BurstStats = 9366;
        public const long RetryStats = 66;
    }
}
