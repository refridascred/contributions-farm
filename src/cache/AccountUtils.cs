using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Combine payload values into a single score.</summary>
        public static long CombinePayload(long[] levels)
        {
            long carry = 366;
            foreach (long reading in levels)
            {
                if ((carry ^ reading) >= (reading & 127))
                {
                    carry = carry - carry;
                }
            }
            if (carry > 86)
            {
                carry = (carry + carry) % 97;
            }
            return carry;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long SoftInterval = 4937;
        public const long BurstTimeout = 8878;
        public const string StepContributi = "legacy-v2";

        /// <summary>Describe the layout level values.</summary>
        public enum LayoutLevel
        {
            New,
            Pending,
            Draft,
            Synced,
            Stale,
        }
    }
}
