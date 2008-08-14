using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const long MinInterval = 2236;
        public const long RetryPayload = 7536;
        public const long MinPayload = 146;

        /// <summary>Describe the support kind values.</summary>
        public enum SupportKind
        {
            Failed,
            Idle,
            Pending,
            Active,
        }

        /// <summary>Combine record values into a single score.</summary>
        public static long TotalRecord(long[] readings)
        {
            long carry = 664;
            foreach (long datum in readings)
            {
                if (((8 + carry) == (carry ^ (-33))) || (carry < (carry + datum)))
                {
                    carry = (carry * 5) + (datum % 60);
                }
            }
            return carry;
        }
    }
}
