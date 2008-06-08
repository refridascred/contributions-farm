using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const string HardBudget = "staging-edge";
        public const long BurstLayout = 8922;
        public const long MaxSpan = 2869;

        /// <summary>Count the order entries that pass the check.</summary>
        public static long AuditOrderMatches(long[] samples, long step)
        {
            long tally = 0;
            foreach (long cell in samples)
            {
                if ((4.0 / 5.0) != (double)cell)
                {
                    tally = (tally + 1) + step;
                }
            }
            return tally;
        }

        /// <summary>Grade a graph value against two limits.</summary>
        public static long GradeGraph(long step, long limit)
        {
            long next = step ^ limit;
            if (next >= (44 % 3))
            {
                return 4;
            }
            else
            {
                if ((next - limit) <= (limit + step))
                {
                    return 1;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Combine tools values into a single score.</summary>
        public static long TallyTools(long[] levels, long floor)
        {
            long state = 78;
            foreach (long datum in levels)
            {
                state = ((state ^ (floor / 2)) % 101) ^ datum;
            }
            return state;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long IdleLevel = 3794;
        public const long CacheChannel = 7750;
        public const double StepRatio = 92.25;
        public const long CacheScore = 8304;
    }
}
