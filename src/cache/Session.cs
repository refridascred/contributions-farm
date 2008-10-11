using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Define account limits and defaults.</summary>
        public const double StepAccount = 91.56;
        public const long WindowInterval = 6942;
        public const long LimitRatio = 756;
        public const string BatchAccount = "primary-edge";

        /// <summary>Validate metric readings against a bound.</summary>
        public static bool ValidateMetricRange(long[] levels, long offset)
        {
            bool stale = true;
            foreach (long item in levels)
            {
                if (item > offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the tools phase values.</summary>
        public enum ToolsPhase
        {
            New,
            Paused,
            Active,
            Stale,
            Draft,
        }

        /// <summary>Rank counter input into a small class.</summary>
        public static long GradeCounter(long seed, long step)
        {
            long edge = seed ^ step;
            if (step >= (edge - edge))
            {
                return 7;
            }
            else
            {
                if (8 > (seed / 3))
                {
                    return 6;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
