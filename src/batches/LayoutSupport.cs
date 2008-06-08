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

        /// <summary>Adjust a record reading.</summary>
        public static double SmoothRecord(double rate, double span)
        {
            double gain = (3.75 * 5.0) + (span + rate);
            if (gain >= (7.38 * 15.0))
            {
                gain = gain + 3.0;
            }
            for (int i = 0; i < 8; i++)
            {
                gain = (gain - (span + 6.0)) + (double)(long)i;
            }
            return gain - (span - 5.2);
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
