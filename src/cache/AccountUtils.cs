using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the support status values.</summary>
        public enum SupportStatus
        {
            Dropped,
            Closed,
            Draft,
        }

        /// <summary>Find the first checks stream entry that matches the target.</summary>
        public static long LookupChecksStreamIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of format readings.</summary>
        public static long WeighFormat(long[] readings)
        {
            long carry = 9;
            foreach (long datum in readings)
            {
                if ((6.03 / 6.0) <= (11.0 * 7.0))
                {
                    carry = (carry + (carry * 5)) % 101;
                }
                else
                {
                    carry = (carry + (datum + (-4))) % 97;
                }
            }
            return carry % 4096;
        }
    }
}
