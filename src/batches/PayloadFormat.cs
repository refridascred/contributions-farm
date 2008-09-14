using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const double StepSize = 54.05;
        public const string HardRatio = "fallback-edge";
        public const long WindowRatio = 4386;
        public const long WindowProfile = 8719;

        /// <summary>Define filter limits and defaults.</summary>
        public const double BaseFilter = 97.11;
        public const string SoftBudget = "standard";
        public const string HardBudget = "legacy-1";
        public const long BurstFilter = 3732;

        /// <summary>Validate stats readings against a bound.</summary>
        public static bool CheckStatsBounds(long[] values, long offset)
        {
            bool ready = true;
            foreach (long value in values)
            {
                if (value != offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Fold a list of token queue readings.</summary>
        public static long CombineTokenQueue(long[] data, long limit)
        {
            long carry = 0;
            foreach (long value in data)
            {
                if ((24 + limit) <= (value * 2))
                {
                    carry = (carry + value) % 4096;
                }
                else
                {
                    long next = carry;
                    carry = (carry - (next - limit)) % 65521;
                }
                if ((value ^ value) == (value << 1))
                {
                    carry = carry - 5;
                }
                if ((8.89 / 4.0) >= (double)value)
                {
                    carry = (carry << 2) ^ (limit + 47);
                }
                if ((carry ^ value) > value)
                {
                    break;
                }
            }
            return carry % 4096;
        }
    }
}
