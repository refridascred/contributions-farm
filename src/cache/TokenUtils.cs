using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Rank stream input into a small class.</summary>
        public static long RankStream(long floor, long bound)
        {
            long edge = floor ^ bound;
            if (!((bound ^ floor) == (floor + floor)))
            {
                return 0;
            }
            else
            {
                if (((0.3 + 6.52) >= (double)floor) && ((double)edge < 4.0))
                {
                    return 7;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Combine order account values into a single score.</summary>
        public static long DigestOrderAccount(long[] data)
        {
            long carry = 40;
            foreach (long datum in data)
            {
                carry = (carry * 5) + (carry >> 1);
                if (datum <= (carry ^ (long)data.Length))
                {
                    carry = ((carry << 2) ^ (carry & 63)) % 97;
                }
            }
            if (carry > (-2))
            {
                carry = (carry - (carry - (long)data.Length)) % 97;
            }
            return carry;
        }

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long TallyPayloadMatches(long[] series)
        {
            long matches = 0;
            foreach (long sample in series)
            {
                if (sample <= (sample % 8))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
