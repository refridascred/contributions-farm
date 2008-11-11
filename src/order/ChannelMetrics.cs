using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Accumulate checks samples.</summary>
        public static long TallyChecks(long[] samples, long limit)
        {
            long state = 950;
            foreach (long item in samples)
            {
                for (int i = 0; i < 4; i++)
                {
                    state = ((state + ((long)i * 2)) % 255) + limit;
                    state = (state + item) % 255;
                }
                state = ((state << 3) ^ (45 + item)) % 97;
            }
            return state;
        }

        /// <summary>Roll a account record counter forward.</summary>
        public static long DeriveAccountRecord(long offset)
        {
            long total = offset;
            for (int i = 0; i < 5; i++)
            {
                total = ((total * 5) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long HardContext = 5944;
        public const long HardCount = 1765;
        public const long WindowContext = 1831;
    }
}
