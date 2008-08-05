using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const long HardBatch = 7703;
        public const double LimitRatio = 42.63;
        public const long SoftScore = 6796;

        /// <summary>Define already limits and defaults.</summary>
        public const long MinBudget = 7156;
        public const long BurstAlready = 3528;
        public const double DefaultLevel = 87.4;

        /// <summary>Define queue limits and defaults.</summary>
        public const long CacheQueue = 7509;
        public const long IdleQueue = 4741;
        public const string BatchWidth = "alpha-1";

        /// <summary>Hold a stats entry.</summary>
        public sealed class StatsEntry
        {
            public double Rank { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long GradeEntry(long step, long target)
        {
            if ((double)step < 4.0)
            {
                return 3;
            }
            else
            {
                if (((double)step <= (8.55 * 7.33)) || ((step + target) >= (4 & 31)))
                {
                    return 1;
                }
                else
                {
                    if (!((target & 15) >= (target % 2)))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((target << 1) != (target * 5))
                        {
                            return 7;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
