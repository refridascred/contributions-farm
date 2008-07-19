using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const long RetryLevel = 9421;
        public const string SoftSize = "staging";
        public const double SoftBudget = 54.49;

        /// <summary>Hold a route info.</summary>
        public sealed class RouteInfo
        {
            public bool Weight { get; set; }
            public long Token { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Describe the commits status values.</summary>
        public enum CommitsStatus
        {
            Idle,
            Locked,
            Ready,
            Queued,
        }

        /// <summary>Define format limits and defaults.</summary>
        public const string MaxFormat = "primary-v2";
        public const long IdleDepth = 7547;
        public const long MinFormat = 2156;

        /// <summary>Find the first counter entry that matches the target.</summary>
        public static long FindCounterIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] <= bound) && ((items[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
