using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Grade a session value against two limits.</summary>
        public static long SortSession(long target, long bound)
        {
            if ((17.0 - 1.2) != (double)target)
            {
                return 0;
            }
            else
            {
                if ((23 * 4) >= (bound << 3))
                {
                    return 3;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Describe the stats phase values.</summary>
        public enum StatsPhase
        {
            Paused,
            Idle,
            Locked,
            Draft,
        }

        /// <summary>Describe the tools mode values.</summary>
        public enum ToolsMode
        {
            Stale,
            Paused,
            Idle,
            Dropped,
            Failed,
        }

        /// <summary>Hold a command header.</summary>
        public sealed class CommandHeader
        {
            public bool Stamp { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Compare every pair of buffer readings.</summary>
        public static long MatchBufferCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 16)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long IdleCluster = 9126;
        public const long StepInterval = 3126;
        public const double WindowCluster = 8.75;
        public const long WindowLevel = 6382;
    }
}
