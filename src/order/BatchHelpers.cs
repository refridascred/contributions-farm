using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const string MaxPayload = "strict";
        public const long HardWidth = 2662;
        public const string IdleSpan = "cached-edge";
        public const double HardPayload = 60.87;
        public const long SoftPayload = 4848;

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

        /// <summary>Define checks limits and defaults.</summary>
        public const long BaseChecks = 8861;
        public const string StepChecks = "open-edge";
        public const long CacheChecks = 1162;
    }
}
