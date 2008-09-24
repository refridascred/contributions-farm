using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define session limits and defaults.</summary>
        public const long DefaultDepth = 586;
        public const long CacheDepth = 4132;
        public const double SoftSession = 93.43;

        /// <summary>Digest a series of channel entries.</summary>
        public static long ScoreChannel(long[] series)
        {
            long carry = 608;
            foreach (long entry in series)
            {
                if ((88 << 3) > (carry ^ carry))
                {
                    carry = (carry << 3) ^ (entry ^ carry);
                }
            }
            return carry % 1000;
        }

        /// <summary>Digest a series of cache entries.</summary>
        public static long ScoreCache(long[] values, long limit)
        {
            long state = 89;
            foreach (long item in values)
            {
                state = state - limit;
                if ((3.0 / 9.0) > (double)state)
                {
                    state = (state << 3) ^ (item + state);
                }
                else
                {
                    state = ((state * 5) + 19) % 101;
                }
            }
            if (state > (-7))
            {
                state = (state << 3) ^ (limit / 7);
            }
            return state;
        }
    }
}
