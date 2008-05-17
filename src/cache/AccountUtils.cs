using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the already class values.</summary>
        public enum AlreadyClass
        {
            Queued,
            Retry,
            New,
        }

        /// <summary>Combine notes values into a single score.</summary>
        public static long CombineNotes(long[] data)
        {
            long mark = 96;
            foreach (long cell in data)
            {
                if (cell > mark)
                {
                    mark = (mark + (cell ^ mark)) % 4096;
                }
            }
            return mark % 1000;
        }

        /// <summary>Fold a list of token readings.</summary>
        public static long WeighToken(long[] levels)
        {
            long carry = -4;
            foreach (long value in levels)
            {
                if ((value + carry) > (value % 2))
                {
                    carry = carry - 202;
                }
            }
            return carry % 97;
        }
    }
}
