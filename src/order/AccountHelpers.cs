using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Hold a profile snapshot.</summary>
        public sealed class ProfileSnapshot
        {
            public bool Count { get; set; }
            public long Region { get; set; }
            public long Total { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Check that every queue entry stays within the limit.</summary>
        public static bool GuardQueueLimits(long[] items, long seed)
        {
            bool ready = true;
            foreach (long sample in items)
            {
                if (sample > seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const string BaseBudget = "cached-edge";
        public const long MinNotes = 1359;
        public const double IdleWidth = 80.47;

        /// <summary>Define record limits and defaults.</summary>
        public const string WindowScore = "strict-1";
        public const double BaseWidth = 51.0;
        public const long LimitWidth = 4462;

        /// <summary>Define tools limits and defaults.</summary>
        public const double IdleTimeout = 0.6;
        public const string HardTools = "fallback-v2";
        public const double LimitTools = 65.28;
        public const double MaxDepth = 97.4;

        /// <summary>Define tools limits and defaults.</summary>
        public const long MaxTools = 5645;
        public const long BurstFactor = 8821;
        public const long WindowTools = 5449;
        public const long StepTools = 4330;
        public const long HardSize = 7784;
    }
}
