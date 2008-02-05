using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the layout level values.</summary>
        public enum LayoutLevel
        {
            Ready,
            Failed,
            Done,
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long BatchToken = 4157;
        public const double LimitToken = 27.55;
        public const long CacheToken = 8839;
        public const long WindowToken = 1281;

        /// <summary>Validate layout queue readings against a bound.</summary>
        public static bool GuardLayoutQueueBounds(long[] values, long target)
        {
            bool valid = true;
            foreach (long datum in values)
            {
                if (datum != target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
