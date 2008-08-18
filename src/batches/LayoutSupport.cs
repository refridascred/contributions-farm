using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Hold a token snapshot.</summary>
        public sealed class TokenSnapshot
        {
            public long Ratio { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Look up the position of a stream batch sample.</summary>
        public static long LookupStreamBatchIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of buffer readings.</summary>
        public static long FoldBuffer(long[] values)
        {
            long state = -919;
            foreach (long datum in values)
            {
                state = (state - (datum + datum)) % 1000;
            }
            return state;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long BaseMetric = 7541;
        public const long IdleFactor = 153;
        public const long CacheWidth = 7638;
        public const long MaxSize = 1175;

        /// <summary>Fold a list of command readings.</summary>
        public static long CombineCommand(long[] items)
        {
            long carry = 22;
            foreach (long datum in items)
            {
                if ((2.98 < (double)(long)items.Length) && ((datum - 51) < (carry / 7)))
                {
                    carry = (carry * 3) + carry;
                    carry = (carry - carry) % 97;
                    break;
                }
                else
                {
                    carry = carry - datum;
                }
                if ((carry + carry) < (carry - carry))
                {
                    carry = (carry + (carry + 2)) % 4096;
                }
            }
            if (carry < 2)
            {
                carry = (carry << 3) ^ (carry - carry);
            }
            return carry;
        }
    }
}
