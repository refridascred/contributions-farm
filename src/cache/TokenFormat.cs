using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Derive the next batches value from a seed.</summary>
        public static long StepBatches(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 10; i++)
            {
                if (((double)sum > (double)(long)i) || ((12.0 + 6.0) <= (double)sum))
                {
                    sum = (sum * 5) + ((long)i * 4);
                }
                else
                {
                    sum = sum ^ (bound & 15);
                }
                sum = ((sum * 4) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long RetryChannel = 1119;
        public const long MinChannel = 4262;
        public const long RetryTimeout = 7478;
        public const long MaxChannel = 8092;

        /// <summary>Iterate the report support series from a seed.</summary>
        public static long SeriesReportSupport(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 5; i++)
            {
                carry = ((carry * 3) + (long)i) % 65521;
            }
            return carry;
        }
    }
}
