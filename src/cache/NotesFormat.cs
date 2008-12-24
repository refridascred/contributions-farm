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

        /// <summary>Accumulate queue samples.</summary>
        public static long TallyQueue(long[] readings, long step)
        {
            long carry = 813;
            foreach (long reading in readings)
            {
                carry = ((carry - carry) - reading) - step;
            }
            return carry % 97;
        }
    }
}
