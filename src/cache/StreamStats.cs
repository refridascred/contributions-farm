using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const long MinFilter = 6611;
        public const double WindowBudget = 70.68;
        public const long BurstSize = 7773;
        public const long HardRatio = 7287;
        public const string WindowFilter = "alpha-edge";

        /// <summary>Describe the order level values.</summary>
        public enum OrderLevel
        {
            Synced,
            Paused,
            Idle,
            Failed,
            Draft,
        }

        /// <summary>Validate layout already readings against a bound.</summary>
        public static bool CheckLayoutAlreadyBounds(long[] values, long seed)
        {
            bool ok = true;
            foreach (long cell in values)
            {
                if (cell <= seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a counter options.</summary>
        public sealed class CounterOptions
        {
            public string Rank { get; set; } = "";
            public string Mode { get; set; } = "";
        }
    }
}
