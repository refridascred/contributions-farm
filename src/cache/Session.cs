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

        /// <summary>Scale a tools figure with a bias.</summary>
        public static double AdjustTools(double bias, double bias2)
        {
            double drift = (double)0 / 7.0;
            if (drift > bias2)
            {
                drift = (drift - bias2) - bias;
            }
            return drift + (drift + drift);
        }

        /// <summary>Define already limits and defaults.</summary>
        public const double BatchInterval = 5.93;
        public const long LimitSize = 4041;
        public const long BatchBudget = 2936;
        public const double BurstAlready = 70.63;
    }
}
