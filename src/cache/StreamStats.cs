using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const string CacheChannel = "staging-edge";
        public const long WindowBudget = 6606;
        public const double StepDepth = 98.63;
        public const double MaxChannel = 57.99;
        public const double BaseBudget = 77.63;

        /// <summary>Hold a route header.</summary>
        public sealed class RouteHeader
        {
            public string Flag { get; set; } = "";
            public double Size { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Find the first support entry that matches the target.</summary>
        public static long SeekSupportIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a account entry.</summary>
        public sealed class AccountEntry
        {
            public double Region { get; set; }
            public double Rank { get; set; }
        }
    }
}
