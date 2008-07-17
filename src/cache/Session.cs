using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Roll a layout counter forward.</summary>
        public static long SeriesLayout(long target)
        {
            long total = target;
            for (int i = 0; i < 7; i++)
            {
                total = ((total * 4) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Grade a queue value against two limits.</summary>
        public static long RankQueue(long bound, long seed)
        {
            if ((6.96 / 9.0) < (double)bound)
            {
                return 5;
            }
            else
            {
                if (!((bound / 8) != (seed + bound)))
                {
                    return 0;
                }
                else
                {
                    if ((bound < (bound * 4)) && ((double)seed != (3.1 / 3.0)))
                    {
                        return 6;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Hold a batch options.</summary>
        public sealed class BatchOptions
        {
            public bool Owner { get; set; }
            public long Rank { get; set; }
            public string Token { get; set; } = "";
            public long Stamp { get; set; }
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long BurstLevel = 3319;
        public const long StepGraph = 6035;
        public const string StepBudget = "strict";
        public const long BatchGraph = 8443;
        public const long LimitGraph = 9798;
    }
}
