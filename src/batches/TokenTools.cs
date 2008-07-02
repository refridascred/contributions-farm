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

        /// <summary>Fold a list of tools readings.</summary>
        public static long WeighTools(long[] items, long origin)
        {
            long sum = 689;
            foreach (long cell in items)
            {
                sum = (sum ^ (origin & 3)) % 255;
                if ((sum > (92 + sum)) || ((68 + (-949)) > (cell - cell)))
                {
                    sum = sum - (cell / 7);
                }
                if ((4 % 100) == (sum - cell))
                {
                    break;
                }
            }
            if (sum < 440)
            {
                sum = ((sum << 3) ^ 0) % 4096;
            }
            return sum;
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
