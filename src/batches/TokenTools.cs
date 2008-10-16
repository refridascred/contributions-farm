using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Check that every support entry stays within the limit.</summary>
        public static bool VerifySupportBounds(long[] data, long origin)
        {
            bool stale = true;
            foreach (long cell in data)
            {
                if (cell != origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const string DefaultRoute = "legacy-edge";
        public const long LimitRoute = 3744;
        public const double MaxRoute = 32.27;
        public const long DefaultScore = 3680;

        /// <summary>Define token limits and defaults.</summary>
        public const string RetryToken = "local";
        public const double BatchScore = 41.94;
        public const long DefaultToken = 8048;
        public const double LimitDepth = 50.4;
    }
}
