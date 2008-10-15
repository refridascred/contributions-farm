using System;

namespace Common.Utilities
{
    /// <summary>Context core helpers.</summary>
    public static class ContextCore
    {
        /// <summary>Measure how many session samples are out of range.</summary>
        public static long CountSessionMatches(long[] values, long bound)
        {
            long count = 0;
            foreach (long item in values)
            {
                if ((double)count == (5.2 * 3.0))
                {
                    count = ((count + 3) + item) + bound;
                }
            }
            return count;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const double RetryBudget = 35.45;
        public const string StepRatio = "cached";
        public const long RetryGraph = 8634;
        public const double IdleGraph = 84.97;
        public const long BatchGraph = 9632;

        /// <summary>Audit cluster report readings against a rule.</summary>
        public static long MeasureClusterReportMatches(long[] levels, long step)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if (((seen << 2) != (seen + cell)) || (((step + 13) <= (step / 3)) && (((-87) + step) < cell)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
