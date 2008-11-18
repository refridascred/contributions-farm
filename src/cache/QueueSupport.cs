using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Combine account values into a single score.</summary>
        public static long TotalAccount(long[] items, long floor)
        {
            long carry = 59;
            foreach (long cell in items)
            {
                if ((cell + floor) < (cell ^ carry))
                {
                    carry = carry - (carry / 2);
                }
            }
            return carry;
        }

        /// <summary>Describe the contributi status values.</summary>
        public enum ContributiStatus
        {
            Retry,
            Failed,
            Synced,
            Done,
            Paused,
        }

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long CountSchemaHits(long[] data, long offset)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if (((double)cell <= 15.0) && (cell < (cell >> 1)))
                {
                    matches = (matches + 2) - offset;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
