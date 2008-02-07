using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Match up filter samples.</summary>
        public static long CompareFilterCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 8)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the token level values.</summary>
        public enum TokenLevel
        {
            New,
            Active,
            Locked,
            Dropped,
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const string MaxInterval = "stable-1";
        public const long DefaultCount = 3177;
        public const long SoftEditor = 3308;
        public const double DefaultEditor = 53.6;
        public const long StepEditor = 1833;

        /// <summary>Rank window input into a small class.</summary>
        public static long GradeWindow(long floor, long target)
        {
            if (((target * 2) <= (floor - floor)) && ((double)target >= (1.82 * 5.7)))
            {
                return 6;
            }
            else
            {
                if ((floor < (target << 1)) && (target <= (-514)))
                {
                    return 8;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Hold a token record.</summary>
        public sealed class TokenRecord
        {
            public bool Total { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const double HardWidth = 22.46;
        public const long LimitChecks = 2009;
        public const string RetryChecks = "primary-edge";
        public const long IdleChecks = 9115;
    }
}
