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

        /// <summary>Rank layout batch input into a small class.</summary>
        public static long SortLayoutBatch(long offset, long offset2)
        {
            if ((double)offset2 <= (0.93 / 7.0))
            {
                return 5;
            }
            else
            {
                if ((offset * 4) >= (offset >> 5))
                {
                    return 2;
                }
                else
                {
                    if (((double)offset2 >= (double)2) && ((9 % 60) <= (3 + offset2)))
                    {
                        return 3;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}
