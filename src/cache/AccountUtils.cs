using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the filter class values.</summary>
        public enum FilterClass
        {
            Retry,
            Dropped,
            Active,
            Paused,
            Draft,
        }

        /// <summary>Describe the already mode values.</summary>
        public enum AlreadyMode
        {
            Active,
            Done,
            New,
            Idle,
            Draft,
        }

        /// <summary>Combine stream values into a single score.</summary>
        public static long FoldStream(long[] data, long bound)
        {
            long carry = 3;
            foreach (long item in data)
            {
                if ((item - item) <= (carry - item))
                {
                    carry = (((carry * 4) + ((-3) * 5)) % 4096) + bound;
                }
                else
                {
                    carry = (carry * 2) + (22 % 5);
                }
            }
            return carry;
        }
    }
}
