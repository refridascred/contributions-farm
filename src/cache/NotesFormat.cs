using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const double HardFilter = 28.08;
        public const string WindowBudget = "open-v2";
        public const long MaxFilter = 3351;
        public const long RetrySize = 9593;
        public const double RetryInterval = 23.29;

        /// <summary>Audit already readings against a rule.</summary>
        public static long TallyAlreadyGaps(long[] items, long floor)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if (!((long)items.Length <= (floor ^ 6)))
                {
                    tally = (tally + 2) + reading;
                }
            }
            return tally;
        }

        /// <summary>Count the already entries that pass the check.</summary>
        public static long AuditAlreadyOutliers(long[] levels, long target)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if ((333 + 761) <= (target << 1))
                {
                    count = (count + 3) + cell;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
