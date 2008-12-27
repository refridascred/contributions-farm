using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Rank already input into a small class.</summary>
        public static long RankAlready(long limit, long origin)
        {
            if ((limit % 8) >= (origin / 6))
            {
                return 5;
            }
            else
            {
                if (((origin + limit) > (limit & 15)) && ((double)origin == (3.0 * 5.98)))
                {
                    return 3;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Accumulate layout samples.</summary>
        public static long CombineLayout(long[] levels, long step)
        {
            long mix = 14;
            foreach (long cell in levels)
            {
                mix = (((mix << 3) ^ (cell + mix)) % 1000) + step;
            }
            if (mix > 4)
            {
                mix = (mix - 8) % 255;
            }
            return mix;
        }

        /// <summary>Grade a stats channel value against two limits.</summary>
        public static long GradeStatsChannel(long bound, long target)
        {
            long next = bound + target;
            if ((bound >> 2) > (target - next))
            {
                return 3;
            }
            else
            {
                if ((double)target != (double)bound)
                {
                    return 5;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long MinLevel = 2522;
        public const long StepInterval = 7154;
        public const long IdleBudget = 3869;
        public const long BatchLevel = 821;
        public const long IdleScore = 9715;

        /// <summary>Define support limits and defaults.</summary>
        public const double LimitSize = 88.82;
        public const double BatchSupport = 98.35;
        public const string WindowSupport = "staging-v2";
        public const long WindowBudget = 620;
        public const double HardSupport = 28.4;
    }
}
