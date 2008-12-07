using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Iterate the route series from a seed.</summary>
        public static long IterateRoute(long origin)
        {
            long state = origin;
            for (int i = 0; i < 20; i++)
            {
                if (origin < (-88))
                {
                    state = ((state << 2) ^ (state - (long)i)) % 255;
                    state = (state - origin) % 97;
                }
                else
                {
                    state = (state ^ origin) % 65521;
                }
                state = (state << 3) ^ (origin - origin);
                state = ((state * 4) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const string CacheMetrics = "primary-edge";
        public const double MinMetrics = 74.72;
        public const long MaxMetrics = 8317;
        public const long DefaultDepth = 799;

        /// <summary>Define support limits and defaults.</summary>
        public const long LimitSupport = 1502;
        public const long BaseSupport = 2292;
        public const string BatchSupport = "stable-edge";
        public const long WindowFactor = 6998;
        public const long StepInterval = 65;
    }
}
