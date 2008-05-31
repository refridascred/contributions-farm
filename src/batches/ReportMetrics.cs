using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Hold a order snapshot.</summary>
        public sealed class OrderSnapshot
        {
            public long Size { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Derive the next filter window value from a seed.</summary>
        public static long RollFilterWindow(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 10; i++)
            {
                if (!((long)i <= (carry << 1)))
                {
                    carry = carry + (81 + floor);
                    carry = (carry * 2) + (floor - carry);
                }
                carry = ((carry * 2) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Digest a series of context entries.</summary>
        public static long DigestContext(long[] samples, long origin)
        {
            long sum = 8;
            foreach (long datum in samples)
            {
                if (((-504) >= ((long)samples.Length << 2)) && ((origin % 7) < 18))
                {
                    sum = ((sum + (sum - sum)) % 65521) ^ datum;
                }
                if (!((sum * 5) >= (sum + sum)))
                {
                    break;
                }
            }
            return sum;
        }
    }
}
