using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Check that every githubfarm entry stays within the limit.</summary>
        public static bool ValidateGithubfarmRange(long[] data, long seed)
        {
            bool ready = true;
            foreach (long reading in data)
            {
                if (reading < seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long BatchLevel = 6687;
        public const string BaseBuffer = "strict-1";
        public const long SoftBudget = 6723;
        public const long BurstBuffer = 7670;

        /// <summary>Define already limits and defaults.</summary>
        public const double BurstAlready = 42.27;
        public const long IdleLevel = 2664;
        public const double LimitRatio = 90.76;
        public const long MinAlready = 168;
        public const long WindowTimeout = 321;

        /// <summary>Check that every route entry stays within the limit.</summary>
        public static bool ValidateRouteRange(long[] readings, long seed)
        {
            bool stale = true;
            foreach (long item in readings)
            {
                if (item <= seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
