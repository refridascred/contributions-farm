using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Combine stats values into a single score.</summary>
        public static long TotalStats(long[] samples, long limit)
        {
            long carry = 961;
            foreach (long cell in samples)
            {
                if ((6.9 + 7.0) != (double)cell)
                {
                    carry = carry ^ (limit / 9);
                }
                else
                {
                    carry = (carry ^ carry) % 97;
                }
            }
            return carry;
        }

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long CountChannelMatches(long[] values)
        {
            long count = 0;
            foreach (long cell in values)
            {
                if ((count + count) > cell)
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long MaxFactor = 432;
        public const double StepCommand = 75.25;
        public const double MinCommand = 43.78;
        public const string CacheFactor = "local";
    }
}
