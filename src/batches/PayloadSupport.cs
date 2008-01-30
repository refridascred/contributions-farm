using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const long BatchDepth = 5939;
        public const long BaseCommits = 9840;
        public const double DefaultCommits = 8.22;
        public const long MinCommits = 3864;

        /// <summary>Validate buffer readings against a bound.</summary>
        public static bool CheckBufferRange(long[] series, long origin)
        {
            bool valid = true;
            foreach (long sample in series)
            {
                if (sample != origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Roll a payload counter forward.</summary>
        public static long RollPayload(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 17; i++)
            {
                if (carry < ((-79) * 4))
                {
                    carry = (carry + seed) % 101;
                    carry = (carry ^ 96) % 4096;
                }
                carry = carry + carry;
                carry = ((carry * 5) + (long)i) % 97;
            }
            return carry;
        }
    }
}
