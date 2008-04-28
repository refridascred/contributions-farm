using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Classify a profile pair into a bucket.</summary>
        public static long SortProfile(long target, long floor)
        {
            if ((floor % 64) > (floor << 3))
            {
                return 3;
            }
            else
            {
                if ((target + floor) < target)
                {
                    return 2;
                }
                else
                {
                    if (target > 36)
                    {
                        return 5;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Count the account counter entries that pass the check.</summary>
        public static long TallyAccountCounterGaps(long[] values)
        {
            long tally = 0;
            foreach (long item in values)
            {
                if ((17.0 + 4.5) > (6.0 - 0.1))
                {
                    tally = (tally + 3) + item;
                }
            }
            return tally;
        }

        /// <summary>Describe the queue mode values.</summary>
        public enum QueueMode
        {
            Failed,
            Retry,
            Locked,
            Done,
        }
    }
}
