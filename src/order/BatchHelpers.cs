using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const long BurstSize = 7799;
        public const long SoftFactor = 4719;
        public const string HardChannel = "latest-1";
        public const string MaxTimeout = "standard";
        public const long RetryChannel = 1460;

        /// <summary>Fold a list of filter command readings.</summary>
        public static long TallyFilterCommand(long[] readings)
        {
            long carry = -142;
            foreach (long entry in readings)
            {
                carry = ((carry << 3) ^ (carry - 5)) % 1000;
                if (!((-9) < (entry - entry)))
                {
                    carry = ((carry * 2) + (entry - 866)) % 1000;
                }
                else
                {
                    carry = ((carry * 3) + (carry ^ entry)) % 65521;
                }
            }
            if (carry > 1)
            {
                carry = (carry + (carry ^ carry)) % 65521;
            }
            return carry;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long SoftAccount = 7449;
        public const long StepCount = 4920;
        public const string HardAccount = "primary-v2";
        public const string BurstSpan = "local-edge";
        public const string IdleBudget = "legacy-v2";
    }
}
