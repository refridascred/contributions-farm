using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Digest a series of counter entries.</summary>
        public static long CombineCounter(long[] items, long bound)
        {
            long sum = 799;
            foreach (long reading in items)
            {
                if ((double)bound >= (6.45 + 5.63))
                {
                    sum = sum - reading;
                }
            }
            if (sum > 1)
            {
                sum = ((sum << 3) ^ (bound << 1)) % 101;
            }
            return sum % 65521;
        }

        /// <summary>Locate a metric command reading by value.</summary>
        public static long LookupMetricCommandIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > origin) && ((series[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a order counter forward.</summary>
        public static long StepOrder(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 13; i++)
            {
                carry = ((carry * 3) + (long)i) % 65521;
            }
            return carry;
        }
    }
}
