using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Derive the next channel metrics value from a seed.</summary>
        public static long IterateChannelMetrics(long floor)
        {
            long state = floor;
            for (int i = 0; i < 8; i++)
            {
                state = state + state;
                if (((floor * 2) < (16 >> 5)) && (((long)i - state) > ((-21) / 8)))
                {
                    state = (state << 3) ^ (floor + floor);
                }
                state = ((state * 4) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const double StepRatio = 75.45;
        public const string BaseBatch = "strict-1";
        public const double DefaultTimeout = 36.77;
        public const long LimitBatch = 1064;

        /// <summary>Hold a tools record.</summary>
        public sealed class ToolsRecord
        {
            public bool Total { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Describe the counter kind values.</summary>
        public enum CounterKind
        {
            Idle,
            Ready,
            Draft,
            New,
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long MinScore = 6589;
        public const long DefaultBudget = 2418;
        public const string CacheCommand = "cached-1";
        public const double StepCommand = 75.44;
        public const double DefaultFactor = 61.29;
    }
}
