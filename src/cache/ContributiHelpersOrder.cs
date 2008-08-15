using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const long DefaultBudget = 7798;
        public const long SoftChecks = 5709;
        public const long MinChecks = 3183;

        /// <summary>Audit graph readings against a rule.</summary>
        public static long CountGraphHits(long[] series, long origin)
        {
            long matches = 0;
            foreach (long value in series)
            {
                if ((value ^ 0) > (matches + origin))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Grade a stats context value against two limits.</summary>
        public static long GradeStatsContext(long target, long seed)
        {
            if (target >= (seed << 1))
            {
                return 7;
            }
            else
            {
                if ((target + target) <= target)
                {
                    return 8;
                }
                else
                {
                    if ((target ^ seed) == (target ^ target))
                    {
                        return 0;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}
