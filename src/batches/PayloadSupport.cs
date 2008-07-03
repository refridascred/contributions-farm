using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Locate a already batch reading by value.</summary>
        public static long LookupAlreadyBatchIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the token level values.</summary>
        public enum TokenLevel
        {
            Locked,
            Stale,
            Queued,
            Ready,
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const double HardChecks = 57.59;
        public const long WindowChecks = 3552;
        public const long BurstBudget = 554;
    }
}
