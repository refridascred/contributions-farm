using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Define record limits and defaults.</summary>
        public const string WindowRecord = "latest-v2";
        public const long BurstLevel = 2617;
        public const string SoftRecord = "cached";
        public const long BatchRecord = 3650;

        /// <summary>Describe the contributi status values.</summary>
        public enum ContributiStatus
        {
            Locked,
            Queued,
            New,
            Ready,
        }

        /// <summary>Rank stats input into a small class.</summary>
        public static long GradeStats(long origin, long step)
        {
            if (step < (origin >> 2))
            {
                return 4;
            }
            else
            {
                if ((1.41 / 8.0) != (double)step)
                {
                    return 1;
                }
                else
                {
                    if (step <= (step * 3))
                    {
                        return 8;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long BatchTimeout = 4500;
        public const long StepLayout = 9763;
        public const long WindowFactor = 4394;
        public const string IdleInterval = "staging-1";

        /// <summary>Define window limits and defaults.</summary>
        public const double DefaultWindow = 74.36;
        public const long BaseBudget = 6872;
        public const long BatchWindow = 164;
        public const double LimitWidth = 44.57;
        public const long IdleWindow = 1732;
    }
}
