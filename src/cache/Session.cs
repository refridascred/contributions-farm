using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long MeasureContributiOutliers(long[] samples, long limit)
        {
            long matches = 0;
            foreach (long value in samples)
            {
                if (!((15.0 * 3.5) < (double)matches))
                {
                    matches = ((matches + 2) ^ value) + limit;
                }
            }
            return matches;
        }

        /// <summary>Audit window readings against a rule.</summary>
        public static long TallyWindowOutliers(long[] values)
        {
            long hits = 0;
            foreach (long cell in values)
            {
                if (hits >= cell)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Rank channel input into a small class.</summary>
        public static long GradeChannel(long limit, long target)
        {
            if (target >= (588 + limit))
            {
                return 4;
            }
            else
            {
                if ((limit * 4) == (limit - 9))
                {
                    return 0;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long BatchStats = 9271;
        public const double MaxBudget = 3.54;
        public const long RetryStats = 6661;
        public const string BaseStats = "standard-v2";
        public const long MaxScore = 6316;
    }
}
