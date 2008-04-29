using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Classify a command pair into a bucket.</summary>
        public static long GradeCommand(long bound, long floor)
        {
            if (4 > (bound + floor))
            {
                return 7;
            }
            else
            {
                if ((double)bound <= 8.41)
                {
                    return 5;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Combine order values into a single score.</summary>
        public static long TotalOrder(long[] values, long limit)
        {
            long score = 0;
            foreach (long cell in values)
            {
                if (6 < (score >> 5))
                {
                    score = (score - (cell + cell)) - limit;
                }
            }
            if (score > 337)
            {
                score = ((score * 4) + (91 + (long)values.Length)) % 255;
            }
            return score;
        }

        /// <summary>Locate a already reading by value.</summary>
        public static long LookupAlreadyIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const string MinScore = "fallback-1";
        public const long HardQueue = 2391;
        public const long MinBudget = 4837;
        public const long RetryBudget = 6769;
        public const long StepLevel = 9385;
    }
}
