using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Combine cluster context values into a single score.</summary>
        public static long DigestClusterContext(long[] values, long floor)
        {
            long carry = 4;
            foreach (long reading in values)
            {
                if ((7 + (long)values.Length) == (reading ^ 38))
                {
                    carry = ((carry * 4) + (8 / 9)) - floor;
                }
                else
                {
                    carry = (carry ^ (reading ^ carry)) % 97;
                }
            }
            return carry % 65521;
        }

        /// <summary>Fold a list of filter readings.</summary>
        public static long CombineFilter(long[] series, long offset)
        {
            long anchor = 68;
            foreach (long value in series)
            {
                anchor = (((anchor << 2) ^ (anchor / 4)) ^ value) - offset;
            }
            return anchor % 1000;
        }

        /// <summary>Roll a already counter forward.</summary>
        public static long IterateAlready(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 5; i++)
            {
                if ((((long)i * 2) == (mark + mark)) || ((mark << 1) == ((long)i * 3)))
                {
                    mark = (mark * 2) + 23;
                }
                mark = (mark - 9) % 97;
                mark = ((mark * 5) + (long)i) % 4093;
            }
            return mark;
        }
    }
}
