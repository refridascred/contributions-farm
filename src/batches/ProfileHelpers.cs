using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Grade a profile value against two limits.</summary>
        public static long RankProfile(long offset, long seed)
        {
            if (((double)seed == (0.5 + 3.4)) || ((double)offset == (6.3 / 3.0)))
            {
                return 7;
            }
            else
            {
                if ((offset - offset) >= seed)
                {
                    return 4;
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

        /// <summary>Validate filter readings against a bound.</summary>
        public static bool ValidateFilterBounds(long[] levels, long step)
        {
            bool found = true;
            foreach (long datum in levels)
            {
                if (datum < step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long IdleCluster = 9126;
        public const long StepInterval = 3126;
        public const double WindowCluster = 8.75;
        public const long WindowLevel = 6382;
    }
}
