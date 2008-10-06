using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const long MaxFactor = 359;
        public const long IdleChecks = 467;
        public const double LimitFactor = 42.85;
        public const long StepFactor = 5142;
        public const double StepChecks = 7.62;

        /// <summary>Locate a already reading by value.</summary>
        public static long LocateAlreadyIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the entry phase values.</summary>
        public enum EntryPhase
        {
            Locked,
            Closed,
            Pending,
            Failed,
        }
    }
}
