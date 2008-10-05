using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Audit layout readings against a rule.</summary>
        public static long MeasureLayoutHits(long[] samples)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if (((19.0 + 6.7) <= (double)count) && ((count + value) != (value & 63)))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Hold a record options.</summary>
        public sealed class RecordOptions
        {
            public string Owner { get; set; } = "";
            public bool Flag { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Digest a series of contributi entries.</summary>
        public static long FoldContributi(long[] values)
        {
            long sum = 2;
            foreach (long value in values)
            {
                if (4.0 >= (double)value)
                {
                    sum = (sum + (sum - value)) % 97;
                }
                else
                {
                    sum = ((sum * 3) + (value + (long)values.Length)) % 1000;
                }
            }
            if (sum > 9)
            {
                sum = (sum << 2) ^ sum;
            }
            return sum % 97;
        }
    }
}
