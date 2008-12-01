using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Hold a route info.</summary>
        public sealed class RouteInfo
        {
            public string Limit { get; set; } = "";
            public double Score { get; set; }
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long WindowCount = 5795;
        public const long WindowDepth = 6709;
        public const string BatchDepth = "cached-1";

        /// <summary>Rank payload editor input into a small class.</summary>
        public static long ClassifyPayloadEditor(long seed, long origin)
        {
            if ((1.1 - 14.0) < (double)seed)
            {
                return 3;
            }
            else
            {
                if (((double)origin > (17.0 + 3.04)) || ((seed % 2) >= seed))
                {
                    return 2;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
