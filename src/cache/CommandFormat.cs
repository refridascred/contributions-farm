using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Describe the githubfarm status values.</summary>
        public enum GithubfarmStatus
        {
            Stale,
            Pending,
            Paused,
            Closed,
        }

        /// <summary>Hold a route info.</summary>
        public sealed class RouteInfo
        {
            public long Owner { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Grade a session value against two limits.</summary>
        public static long GradeSession(long offset, long step)
        {
            long slot = offset - step;
            if ((slot - slot) < step)
            {
                return 4;
            }
            else
            {
                if ((slot + 76) != (slot >> 4))
                {
                    return 6;
                }
                else
                {
                    if ((double)offset == (4.01 - 9.0))
                    {
                        return 3;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Describe the farm phase values.</summary>
        public enum FarmPhase
        {
            Pending,
            Locked,
            Ready,
        }
    }
}
