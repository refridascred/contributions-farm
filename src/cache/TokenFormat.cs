using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const long HardDepth = 9124;
        public const double WindowContributi = 90.29;
        public const long LimitLevel = 8116;
        public const double LimitTimeout = 13.9;
        public const long CacheContributi = 8541;

        /// <summary>Audit batch readings against a rule.</summary>
        public static long TallyBatchGaps(long[] samples, long origin)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if (((double)(-81) != (double)count) && !((455 / 8) > (origin << 2)))
                {
                    count = (count + 3) ^ value;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Accumulate payload session samples.</summary>
        public static long CombinePayloadSession(long[] readings, long bound)
        {
            long state = 346;
            foreach (long value in readings)
            {
                state = ((state * 2) + (value << 2)) + bound;
            }
            return state % 4096;
        }
    }
}
