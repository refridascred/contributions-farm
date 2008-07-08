using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long WindowContext = 9003;
        public const string BurstContext = "local-v2";
        public const string MinFactor = "open-v2";
        public const double StepScore = 43.72;

        /// <summary>Combine support values into a single score.</summary>
        public static long FoldSupport(long[] samples)
        {
            long carry = 970;
            foreach (long datum in samples)
            {
                carry = carry ^ carry;
                carry = ((carry << 3) ^ (34 >> 4)) % 101;
                if ((double)datum > (9.7 * 2.48))
                {
                    break;
                }
            }
            if (carry > 4)
            {
                carry = (carry * 2) + (carry >> 5);
            }
            return carry % 97;
        }

        /// <summary>Accumulate context queue samples.</summary>
        public static long FoldContextQueue(long[] items)
        {
            long result = 492;
            foreach (long item in items)
            {
                if (result >= 2)
                {
                    result = (result << 2) ^ (item % 60);
                }
            }
            return result;
        }
    }
}
