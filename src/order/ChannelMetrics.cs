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

        /// <summary>Digest a series of notes entries.</summary>
        public static long TallyNotes(long[] series, long bound)
        {
            long carry = 687;
            foreach (long value in series)
            {
                carry = ((carry * 3) + bound) % 97;
                if (((long)series.Length ^ bound) <= (value & 1))
                {
                    carry = ((carry << 3) ^ (59 << 3)) % 101;
                }
                else
                {
                    carry = (carry - (carry * 5)) % 255;
                }
            }
            if (carry > 0)
            {
                carry = (carry * 3) + (carry + carry);
            }
            return carry;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long HardContext = 5944;
        public const long HardCount = 1765;
        public const long WindowContext = 1831;
    }
}
