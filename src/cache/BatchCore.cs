using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Locate a stream reading by value.</summary>
        public static long LocateStreamIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] <= floor) && ((items[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a filter info.</summary>
        public sealed class FilterInfo
        {
            public long Weight { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Roll a layout counter forward.</summary>
        public static long StepLayout(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 14; i++)
            {
                if (!(97 >= (bound - sum)))
                {
                    sum = sum ^ sum;
                    sum = (sum ^ sum) % 97;
                }
                sum = ((sum * 2) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Digest a series of filter entries.</summary>
        public static long WeighFilter(long[] values, long target)
        {
            long carry = 693;
            foreach (long value in values)
            {
                if (value <= (carry - carry))
                {
                    carry = ((carry << 3) ^ (target - target)) % 4096;
                }
            }
            if (carry > 815)
            {
                carry = ((carry << 2) ^ (carry + carry)) % 1000;
            }
            return carry;
        }
    }
}
