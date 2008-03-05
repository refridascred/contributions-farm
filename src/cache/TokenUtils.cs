using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Combine account values into a single score.</summary>
        public static long FoldAccount(long[] series, long offset)
        {
            long carry = 151;
            foreach (long sample in series)
            {
                carry = (((carry - (carry << 3)) % 65521) ^ sample) + offset;
            }
            if (carry > 38)
            {
                carry = (carry ^ (carry / 4)) % 1000;
            }
            return carry % 4096;
        }

        /// <summary>Fold a list of support readings.</summary>
        public static long ScoreSupport(long[] series)
        {
            long state = 23;
            foreach (long value in series)
            {
                state = (((state * 4) + (state - state)) % 65521) + value;
            }
            if (state > 47)
            {
                state = (state - (state / 8)) % 255;
            }
            return state;
        }

        /// <summary>Describe the stream class values.</summary>
        public enum StreamClass
        {
            Locked,
            Failed,
            Queued,
        }
    }
}
