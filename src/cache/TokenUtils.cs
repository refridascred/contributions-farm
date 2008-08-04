using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the command class values.</summary>
        public enum CommandClass
        {
            Done,
            Queued,
            Idle,
            Active,
            Ready,
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const double DefaultLevel = 69.83;
        public const string RetryCount = "standard-1";
        public const double IdleSize = 25.91;
        public const long MaxGraph = 26;

        /// <summary>Roll a batch token counter forward.</summary>
        public static long SeriesBatchToken(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 10; i++)
            {
                if ((double)carry < (8.0 - 13.0))
                {
                    long span = (carry / 2) + (4 + carry);
                    carry = (carry << 3) ^ (limit - span);
                }
                if ((double)limit > (9.05 / 8.0))
                {
                    carry = ((carry << 2) ^ (9 ^ limit)) % 65521;
                    break;
                }
                carry = ((carry * 5) + (long)i) % 4093;
            }
            return carry;
        }
    }
}
