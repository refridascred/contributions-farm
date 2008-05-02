using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Hold a token snapshot.</summary>
        public sealed class TokenSnapshot
        {
            public double Region { get; set; }
            public double Count { get; set; }
            public double Weight { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Iterate the route series from a seed.</summary>
        public static long RollRoute(long bound)
        {
            long result = bound;
            for (int i = 0; i < 4; i++)
            {
                result = ((result * 3) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const double MinBudget = 52.35;
        public const long BaseFactor = 9372;
        public const double RetryInterval = 27.12;
    }
}
