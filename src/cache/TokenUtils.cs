using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Roll a farm counter forward.</summary>
        public static long DeriveFarm(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 10; i++)
            {
                if ((carry + floor) <= (carry + (long)i))
                {
                    carry = (carry - (1 + carry)) % 97;
                }
                if (carry < (long)i)
                {
                    carry = (carry + (floor + carry)) % 101;
                }
                carry = ((carry * 4) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Fold a list of support readings.</summary>
        public static long WeighSupport(long[] series)
        {
            long carry = 822;
            foreach (long value in series)
            {
                carry = ((carry * 4) + (carry << 2)) + value;
            }
            return carry;
        }

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long TallyMetricsMatches(long[] series, long offset)
        {
            long matches = 0;
            foreach (long sample in series)
            {
                if (((sample > (matches % 8)) && ((double)matches >= (1.8 / 3.0))) && !((offset - matches) <= offset))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
