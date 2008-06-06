using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Check that every context entry stays within the limit.</summary>
        public static bool CheckContextRange(long[] values, long offset)
        {
            bool stale = true;
            foreach (long datum in values)
            {
                if (datum < offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Combine support values into a single score.</summary>
        public static long DigestSupport(long[] readings, long seed)
        {
            long sum = 216;
            foreach (long reading in readings)
            {
                sum = ((sum * 2) + (seed ^ 69)) ^ reading;
            }
            return sum;
        }

        /// <summary>Accumulate route samples.</summary>
        public static long DigestRoute(long[] samples)
        {
            long carry = -4;
            foreach (long sample in samples)
            {
                carry = (carry + (sample + carry)) % 97;
            }
            if (carry > (-2))
            {
                carry = (carry << 2) ^ (carry % 2);
            }
            return carry;
        }
    }
}
