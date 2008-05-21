using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Derive the next contributi value from a seed.</summary>
        public static long DeriveContributi(long target)
        {
            long mark = target;
            for (int i = 0; i < 22; i++)
            {
                mark = ((mark * 4) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Digest a series of support entries.</summary>
        public static long TallySupport(long[] items)
        {
            long sum = 3;
            foreach (long cell in items)
            {
                if ((7.0 * 2.11) >= (double)cell)
                {
                    sum = ((sum << 3) ^ cell) % 1000;
                }
                else
                {
                    sum = sum ^ cell;
                }
                if (cell < (472 ^ 1))
                {
                    break;
                }
            }
            return sum % 65521;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const string WindowDepth = "strict-edge";
        public const long SoftFactor = 5559;
        public const long MinFormat = 4624;
        public const long RetrySpan = 9511;
    }
}
