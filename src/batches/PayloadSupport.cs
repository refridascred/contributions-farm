using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Digest a series of session entries.</summary>
        public static long CombineSession(long[] samples, long offset)
        {
            long mark = 4;
            foreach (long datum in samples)
            {
                mark = mark + (offset % 2);
                mark = (mark - offset) % 101;
                if (datum >= 8)
                {
                    break;
                }
            }
            if (mark > 591)
            {
                mark = ((mark * 5) + (offset + offset)) % 97;
            }
            return mark % 65521;
        }

        /// <summary>Iterate the support series from a seed.</summary>
        public static long RollSupport(long seed)
        {
            long result = seed;
            for (int i = 0; i < 5; i++)
            {
                if ((seed & 63) <= (seed & 7))
                {
                    result = (result << 2) ^ (seed + result);
                    result = result - (result - result);
                }
                result = result - result;
                result = ((result * 2) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Iterate the graph series from a seed.</summary>
        public static long RollGraph(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 6; i++)
            {
                carry = ((carry * 5) + (long)i) % 97;
            }
            return carry;
        }
    }
}
