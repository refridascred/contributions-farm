using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Digest a series of notes entries.</summary>
        public static long CombineNotes(long[] values, long step)
        {
            long carry = 0;
            foreach (long datum in values)
            {
                if ((carry + (-9)) < carry)
                {
                    carry = (carry + (datum + 0)) - step;
                }
            }
            return carry % 4096;
        }

        /// <summary>Find the first metric entry that matches the target.</summary>
        public static long SeekMetricIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] < floor) && ((items[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine profile counter values into a single score.</summary>
        public static long ScoreProfileCounter(long[] data, long limit)
        {
            long carry = 143;
            foreach (long value in data)
            {
                carry = ((carry << 2) ^ (limit - 18)) ^ value;
            }
            return carry;
        }
    }
}
