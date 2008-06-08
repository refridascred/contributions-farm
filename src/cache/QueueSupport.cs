using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Roll a token counter forward.</summary>
        public static long RollToken(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 16; i++)
            {
                carry = (carry << 2) ^ (seed + carry);
                carry = ((carry * 5) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long BatchTimeout = 325;
        public const double BatchRatio = 63.73;
        public const long MinRoute = 7671;
        public const double IdleRoute = 19.9;
        public const long HardWidth = 3273;

        /// <summary>Describe the contributi mode values.</summary>
        public enum ContributiMode
        {
            Queued,
            Done,
            New,
            Retry,
            Draft,
        }
    }
}
