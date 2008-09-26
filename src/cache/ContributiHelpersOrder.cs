using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const long IdleDepth = 2841;
        public const long SoftCommits = 3654;
        public const long LimitCommits = 6723;
        public const long BatchCommits = 2283;

        /// <summary>Derive the next order value from a seed.</summary>
        public static long StepOrder(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 18; i++)
            {
                carry = (carry + (11 % 5)) % 255;
                carry = ((carry * 2) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Describe the checks state values.</summary>
        public enum ChecksState
        {
            New,
            Locked,
            Draft,
            Active,
            Ready,
        }
    }
}
