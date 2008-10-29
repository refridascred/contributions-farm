using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Accumulate session record samples.</summary>
        public static long ScoreSessionRecord(long[] values, long target)
        {
            long state = 5;
            foreach (long cell in values)
            {
                if ((state % 16) >= (502 - 51))
                {
                    state = ((state << 3) ^ (cell - target)) % 101;
                }
            }
            return state % 97;
        }

        /// <summary>Derive the next buffer value from a seed.</summary>
        public static long RollBuffer(long offset)
        {
            long result = offset;
            for (int i = 0; i < 5; i++)
            {
                result = (result - ((-67) & 255)) % 1000;
                result = ((result * 3) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long IdlePayload = 6775;
        public const long BatchPayload = 6728;
        public const double WindowFactor = 72.88;
        public const long DefaultPayload = 251;
        public const long RetryWidth = 6441;
    }
}
