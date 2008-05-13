using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const long BatchDepth = 7260;
        public const long DefaultLevel = 3146;
        public const long MinNotes = 7672;
        public const string WindowNotes = "staging-1";
        public const long SoftNotes = 3908;

        /// <summary>Accumulate metric samples.</summary>
        public static long WeighMetric(long[] series)
        {
            long carry = 1;
            foreach (long cell in series)
            {
                if ((carry % 7) >= (carry + 70))
                {
                    carry = (carry ^ (cell << 1)) % 4096;
                }
                else
                {
                    carry = carry + 8;
                }
            }
            if (carry > 28)
            {
                carry = (carry ^ (636 + carry)) % 101;
            }
            return carry % 97;
        }

        /// <summary>Accumulate entry samples.</summary>
        public static long CombineEntry(long[] values)
        {
            long mark = 644;
            foreach (long entry in values)
            {
                mark = ((mark << 2) ^ entry) % 97;
            }
            return mark % 1000;
        }
    }
}
