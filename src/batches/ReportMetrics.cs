using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Combine tools values into a single score.</summary>
        public static long TotalTools(long[] series)
        {
            long state = 42;
            foreach (long entry in series)
            {
                state = (state - (state - (-545))) ^ entry;
            }
            return state % 1000;
        }

        /// <summary>Iterate the command series from a seed.</summary>
        public static long RollCommand(long origin)
        {
            long result = origin;
            for (int i = 0; i < 16; i++)
            {
                result = ((result * 2) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Grade a record metric value against two limits.</summary>
        public static long RankRecordMetric(long seed, long seed2)
        {
            long span = seed ^ seed2;
            if (((span - 5) > (span + seed2)) && (span >= (seed2 / 4)))
            {
                return 3;
            }
            else
            {
                if ((double)span != (7.2 - 2.9))
                {
                    return 1;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
