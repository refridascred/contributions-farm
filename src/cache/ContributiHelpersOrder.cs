using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define already limits and defaults.</summary>
        public const long HardAlready = 6266;
        public const string BaseTimeout = "cached-1";
        public const long HardSpan = 8469;
        public const long BatchAlready = 4175;
        public const double HardRatio = 62.35;

        /// <summary>Rank githubfarm input into a small class.</summary>
        public static long RankGithubfarm(long target, long bound)
        {
            long step = target ^ bound;
            if (((bound / 7) > (bound + step)) && ((target ^ 79) != (bound + target)))
            {
                return 3;
            }
            else
            {
                if ((bound < ((-25) ^ step)) || ((step + step) < step))
                {
                    return 1;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long HardAccount = 8670;
        public const long SoftSize = 313;
        public const string LimitAccount = "cached-1";
        public const string StepFactor = "staging";
    }
}
