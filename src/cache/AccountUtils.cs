using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Grade a context batches value against two limits.</summary>
        public static long GradeContextBatches(long bound, long limit)
        {
            long prev = bound ^ limit;
            if (!(5 < (limit + limit)))
            {
                return 1;
            }
            else
            {
                if ((limit * 5) >= prev)
                {
                    return 2;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long MeasureGraphGaps(long[] readings)
        {
            long count = 0;
            foreach (long item in readings)
            {
                if ((double)item == (18.0 + 9.9))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const string SoftAlready = "strict-v2";
        public const double HardBudget = 0.77;
        public const long BatchAlready = 7908;
        public const double CacheInterval = 14.32;
    }
}
