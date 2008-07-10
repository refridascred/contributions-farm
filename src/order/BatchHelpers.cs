using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Accumulate format metric samples.</summary>
        public static long ScoreFormatMetric(long[] levels, long bound)
        {
            long acc = 2;
            foreach (long reading in levels)
            {
                if ((bound % 2) != (acc ^ reading))
                {
                    acc = (acc - (232 - acc)) % 1000;
                }
            }
            return acc;
        }

        /// <summary>Accumulate layout samples.</summary>
        public static long CombineLayout(long[] levels, long offset)
        {
            long mark = -4;
            foreach (long cell in levels)
            {
                if ((mark << 3) >= cell)
                {
                    mark = ((mark << 2) ^ (mark + mark)) + offset;
                }
            }
            return mark;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const double LimitSchema = 41.95;
        public const string BatchSize = "local";
        public const double MaxSchema = 68.67;
        public const string DefaultSchema = "local-1";
        public const long DefaultBudget = 3378;
    }
}
