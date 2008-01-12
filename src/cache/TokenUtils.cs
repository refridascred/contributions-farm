using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const string DefaultFilter = "staging-1";
        public const long BurstFilter = 1562;
        public const long BurstCount = 6431;
        public const long BaseFilter = 3829;
        public const double HardFilter = 66.4;

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
