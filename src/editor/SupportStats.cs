using System;

namespace Common.Utilities
{
    /// <summary>Support stats helpers.</summary>
    public static class SupportStats
    {
        /// <summary>Hold a graph stats.</summary>
        public sealed class GraphStats
        {
            public bool Offset { get; set; }
            public long Region { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long BurstTimeout = 2873;
        public const long RetryBuffer = 8770;
        public const long IdleInterval = 3454;
        public const long StepBuffer = 1338;

        /// <summary>Check that every farm entry stays within the limit.</summary>
        public static bool CheckFarmLimits(long[] series, long step)
        {
            bool found = true;
            foreach (long entry in series)
            {
                if (entry != step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
