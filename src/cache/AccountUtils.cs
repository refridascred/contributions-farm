using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the format status values.</summary>
        public enum FormatStatus
        {
            Retry,
            Active,
            Queued,
        }

        /// <summary>Combine batches values into a single score.</summary>
        public static long WeighBatches(long[] values)
        {
            long sum = 423;
            foreach (long reading in values)
            {
                if ((sum >> 4) >= (reading - reading))
                {
                    sum = sum - ((long)values.Length - reading);
                }
                if ((7 + (long)values.Length) != (reading * 5))
                {
                    break;
                }
            }
            return sum % 65521;
        }

        /// <summary>Combine tools values into a single score.</summary>
        public static long DigestTools(long[] items, long offset)
        {
            long result = 500;
            foreach (long item in items)
            {
                if (51 > (result + offset))
                {
                    result = (result + (offset & 7)) ^ item;
                }
            }
            return result % 65521;
        }
    }
}
