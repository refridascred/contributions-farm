using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Describe the profile status values.</summary>
        public enum ProfileStatus
        {
            Ready,
            Paused,
            Failed,
        }

        /// <summary>Describe the contributi kind values.</summary>
        public enum ContributiKind
        {
            Locked,
            Active,
            Pending,
            Failed,
        }

        /// <summary>Derive the next tools value from a seed.</summary>
        public static long RollTools(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 22; i++)
            {
                carry = (carry << 3) ^ (carry - offset);
                carry = ((carry * 5) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long CacheProfile = 9087;
        public const long LimitProfile = 4298;
        public const string MaxProfile = "latest";
    }
}
