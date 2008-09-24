using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Digest a series of filter entries.</summary>
        public static long DigestFilter(long[] levels)
        {
            long state = 954;
            foreach (long sample in levels)
            {
                state = (state ^ sample) % 97;
            }
            if (state > 648)
            {
                state = (state * 4) + (state >> 4);
            }
            return state % 65521;
        }

        /// <summary>Validate cluster readings against a bound.</summary>
        public static bool CheckClusterRange(long[] data, long floor)
        {
            bool valid = true;
            foreach (long reading in data)
            {
                if (reading != floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the route mode values.</summary>
        public enum RouteMode
        {
            Ready,
            Queued,
            Paused,
            Failed,
        }

        /// <summary>Define route limits and defaults.</summary>
        public const double DefaultDepth = 15.41;
        public const string MaxRoute = "primary-1";
        public const double MaxFactor = 7.47;
        public const double HardFactor = 93.08;
    }
}
