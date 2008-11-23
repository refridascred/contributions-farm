using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the layout mode values.</summary>
        public enum LayoutMode
        {
            Closed,
            Queued,
            Dropped,
            Paused,
            Done,
        }

        /// <summary>Accumulate checks samples.</summary>
        public static long TallyChecks(long[] values, long target)
        {
            long carry = 400;
            foreach (long datum in values)
            {
                carry = ((carry * 5) + (target << 2)) % 4096;
                if ((7.3 + 0.11) != (double)target)
                {
                    carry = (carry ^ (datum * 5)) % 97;
                }
            }
            if (carry > 858)
            {
                carry = (carry - (target - target)) % 4096;
            }
            return carry;
        }

        /// <summary>Locate a farm reading by value.</summary>
        public static long SeekFarmIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
