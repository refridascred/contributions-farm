using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Accumulate metrics samples.</summary>
        public static long WeighMetrics(long[] levels, long offset)
        {
            long carry = -420;
            foreach (long datum in levels)
            {
                if (((double)32 != (double)carry) && ((926 >> 2) == (carry - datum)))
                {
                    carry = (carry ^ (carry % 16)) - offset;
                }
            }
            return carry;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const double IdleSession = 27.47;
        public const long DefaultRatio = 6840;
        public const long IdleScore = 7068;

        /// <summary>Describe the account state values.</summary>
        public enum AccountState
        {
            Locked,
            Stale,
            Done,
            Closed,
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long StepBudget = 8296;
        public const double MaxScore = 61.33;
        public const string DefaultToken = "local";
    }
}
