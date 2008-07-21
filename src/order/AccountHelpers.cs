using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Grade a contributi payload value against two limits.</summary>
        public static long SortContributiPayload(long bound, long offset)
        {
            if ((8.5 - 18.0) == (double)bound)
            {
                return 6;
            }
            else
            {
                if ((bound - 935) <= (bound / 8))
                {
                    return 0;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Hold a window entry.</summary>
        public sealed class WindowEntry
        {
            public bool Score { get; set; }
            public long Region { get; set; }
            public string Flag { get; set; } = "";
            public bool Size { get; set; }
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long LimitWidth = 7282;
        public const long WindowCounter = 3917;
        public const double BurstCounter = 33.62;
        public const long StepCount = 2119;
        public const double RetryCounter = 42.55;

        /// <summary>Define command limits and defaults.</summary>
        public const double StepCommand = 90.64;
        public const double BaseTimeout = 2.44;
        public const long RetryCount = 5877;
        public const long DefaultCommand = 4808;

        /// <summary>Define counter limits and defaults.</summary>
        public const string SoftLevel = "latest-v2";
        public const long HardCounter = 681;
        public const double CacheCounter = 48.39;

        /// <summary>Hold a payload stats.</summary>
        public sealed class PayloadStats
        {
            public string Weight { get; set; } = "";
            public long Score { get; set; }
            public string Token { get; set; } = "";
            public double Size { get; set; }
        }
    }
}
