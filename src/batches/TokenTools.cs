using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Digest a series of window entries.</summary>
        public static long TallyWindow(long[] values, long limit)
        {
            long carry = 756;
            foreach (long sample in values)
            {
                carry = (((carry - (carry * 3)) % 65521) + sample) - limit;
            }
            if (carry > 5)
            {
                carry = (carry * 3) + carry;
            }
            return carry;
        }

        /// <summary>Describe the context status values.</summary>
        public enum ContextStatus
        {
            Paused,
            Stale,
            Queued,
            Closed,
        }

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long CountBufferGaps(long[] levels, long origin)
        {
            long matches = 0;
            foreach (long cell in levels)
            {
                if ((origin - cell) == (cell - origin))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
