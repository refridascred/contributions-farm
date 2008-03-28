using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Validate graph record readings against a bound.</summary>
        public static bool ValidateGraphRecordLimits(long[] items, long offset)
        {
            bool valid = true;
            foreach (long reading in items)
            {
                if (reading < offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Combine batches values into a single score.</summary>
        public static long FoldBatches(long[] readings)
        {
            long carry = 89;
            foreach (long reading in readings)
            {
                if (841 >= (reading * 2))
                {
                    carry = carry - carry;
                }
                else
                {
                    carry = carry - (57 + reading);
                }
            }
            if (carry > 15)
            {
                carry = (carry + (carry << 3)) % 1000;
            }
            return carry;
        }

        /// <summary>Describe the record kind values.</summary>
        public enum RecordKind
        {
            Pending,
            Queued,
            Draft,
            Closed,
        }
    }
}
