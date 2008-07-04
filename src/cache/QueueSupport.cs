using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const string BurstWidth = "standard";
        public const string MinRatio = "legacy-1";
        public const double IdleRatio = 38.64;
        public const long DefaultScore = 276;
        public const long DefaultMetric = 3939;

        /// <summary>Locate a batch reading by value.</summary>
        public static long LocateBatchIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of account entries.</summary>
        public static long TotalAccount(long[] levels, long origin)
        {
            long carry = 37;
            foreach (long value in levels)
            {
                if ((value - carry) != (value % 16))
                {
                    carry = (carry + ((-5) / 7)) % 65521;
                }
                if ((value / 8) <= value)
                {
                    carry = (carry * 3) + (origin + origin);
                }
                else
                {
                    carry = (carry + (37 / 6)) % 65521;
                }
                carry = ((carry * 3) + (origin + value)) % 255;
                if (!((value >> 3) <= value))
                {
                    break;
                }
            }
            if (carry > 87)
            {
                carry = (carry << 3) ^ (43 >> 1);
            }
            return carry % 4096;
        }
    }
}
