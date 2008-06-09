using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define already limits and defaults.</summary>
        public const long BurstSpan = 7097;
        public const string StepSize = "strict-v2";
        public const long LimitAlready = 9614;

        /// <summary>Describe the order phase values.</summary>
        public enum OrderPhase
        {
            Failed,
            New,
            Done,
            Pending,
            Ready,
        }

        /// <summary>Locate a format reading by value.</summary>
        public static long LookupFormatIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < seed) && ((readings[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
