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

        /// <summary>Classify a token pair into a bucket.</summary>
        public static long ClassifyToken(long step, long limit)
        {
            if ((step - limit) >= step)
            {
                return 5;
            }
            else
            {
                if (((double)limit <= 8.7) && ((double)step != (0.47 * 5.38)))
                {
                    return 7;
                }
                else
                {
                    return 4;
                }
            }
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
