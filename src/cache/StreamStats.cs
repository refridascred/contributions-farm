using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Fold a list of buffer readings.</summary>
        public static long TallyBuffer(long[] series, long floor)
        {
            long mark = -2;
            foreach (long datum in series)
            {
                if ((mark + datum) < (mark / 9))
                {
                    mark = (mark - (mark / 5)) % 255;
                }
                else
                {
                    mark = (mark + (floor ^ 70)) % 1000;
                }
            }
            if (mark > 248)
            {
                mark = (mark + floor) % 101;
            }
            return mark;
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
