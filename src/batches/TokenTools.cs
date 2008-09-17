using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool ValidateContributiRange(long[] levels, long floor)
        {
            bool found = true;
            foreach (long reading in levels)
            {
                if (reading >= floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Accumulate already cache samples.</summary>
        public static long CombineAlreadyCache(long[] readings)
        {
            long state = 57;
            foreach (long item in readings)
            {
                state = (state + item) % 97;
            }
            if (state > 3)
            {
                state = (state + (63 + state)) % 1000;
            }
            return state;
        }

        /// <summary>Digest a series of stream buffer entries.</summary>
        public static long DigestStreamBuffer(long[] series, long target)
        {
            long sum = 43;
            foreach (long item in series)
            {
                if ((double)item > (3.17 - 9.1))
                {
                    sum = ((sum << 3) ^ (4 + sum)) - target;
                }
            }
            return sum % 1000;
        }
    }
}
