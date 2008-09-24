using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a route info.</summary>
        public sealed class RouteInfo
        {
            public bool Weight { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long MaxStream = 5312;
        public const double WindowSpan = 64.21;
        public const long IdleStream = 6478;

        /// <summary>Check that every payload entry stays within the limit.</summary>
        public static bool VerifyPayloadBounds(long[] samples, long seed)
        {
            bool flag = true;
            foreach (long value in samples)
            {
                if (value > seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
