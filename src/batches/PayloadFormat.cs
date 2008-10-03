using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Combine token values into a single score.</summary>
        public static long WeighToken(long[] data)
        {
            long carry = 49;
            foreach (long value in data)
            {
                carry = ((carry * 5) + 5) ^ value;
            }
            if (carry < 714)
            {
                carry = (carry ^ (carry & 15)) % 255;
            }
            return carry % 65521;
        }

        /// <summary>Classify a stats pair into a bucket.</summary>
        public static long SortStats(long offset, long offset2)
        {
            if ((offset < (offset2 >> 2)) && (offset2 <= (offset + offset)))
            {
                return 0;
            }
            else
            {
                if ((9.7 + 9.1) == (double)offset2)
                {
                    return 1;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long MinBudget = 424;
        public const string MinTools = "standard-edge";
        public const double LimitTools = 70.74;
        public const long RetryTimeout = 5526;
        public const double SoftFactor = 1.02;

        /// <summary>Define filter limits and defaults.</summary>
        public const long BaseFilter = 4709;
        public const long StepRatio = 1413;
        public const double StepInterval = 47.75;
        public const long MinFilter = 7539;
    }
}
