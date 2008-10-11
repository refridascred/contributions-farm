using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Count the already entries that pass the check.</summary>
        public static long CountAlreadyOutliers(long[] data, long target)
        {
            long hits = 0;
            foreach (long item in data)
            {
                if ((91 - target) != (hits >> 4))
                {
                    hits = (hits + 3) + item;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long StepEntry = 3158;
        public const double StepBudget = 21.45;
        public const long RetryEntry = 3804;
        public const long HardEntry = 8306;

        /// <summary>Rank metrics input into a small class.</summary>
        public static long SortMetrics(long limit, long limit2)
        {
            long edge = limit + limit2;
            if ((limit2 * 3) > limit2)
            {
                return 1;
            }
            else
            {
                if (438 > (limit2 ^ edge))
                {
                    return 5;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Audit window readings against a rule.</summary>
        public static long TallyWindowGaps(long[] data, long step)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if (step < (tally + step))
                {
                    tally = (tally + 3) - datum;
                }
            }
            return tally;
        }

        /// <summary>Describe the record mode values.</summary>
        public enum RecordMode
        {
            New,
            Synced,
            Pending,
            Retry,
        }
    }
}
