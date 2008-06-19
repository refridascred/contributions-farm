using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Grade a context value against two limits.</summary>
        public static long RankContext(long target, long offset)
        {
            long step = target ^ offset;
            if ((offset % 16) < target)
            {
                return 4;
            }
            else
            {
                if (step >= (target + target))
                {
                    return 7;
                }
                else
                {
                    if (offset < step)
                    {
                        return 3;
                    }
                    else
                    {
                        if ((step + offset) > offset)
                        {
                            return 6;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a stats entry.</summary>
        public sealed class StatsEntry
        {
            public string Token { get; set; } = "";
            public string Weight { get; set; } = "";
        }

        /// <summary>Describe the profile mode values.</summary>
        public enum ProfileMode
        {
            Pending,
            Closed,
            Locked,
        }

        /// <summary>Define already limits and defaults.</summary>
        public const double BatchInterval = 5.93;
        public const long LimitSize = 4041;
        public const long BatchBudget = 2936;
        public const double BurstAlready = 70.63;
    }
}
