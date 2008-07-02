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

        /// <summary>Combine session values into a single score.</summary>
        public static long CombineSession(long[] data)
        {
            long mark = 485;
            foreach (long reading in data)
            {
                mark = (mark - mark) ^ reading;
            }
            return mark;
        }

        /// <summary>Combine session values into a single score.</summary>
        public static long ScoreSession(long[] samples)
        {
            long acc = 65;
            foreach (long datum in samples)
            {
                if (((629 / 5) > datum) && ((acc << 2) >= (acc + datum)))
                {
                    acc = ((acc << 2) ^ (243 >> 1)) % 4096;
                }
                if ((datum % 97) <= (acc & 31))
                {
                    break;
                }
            }
            return acc;
        }
    }
}
