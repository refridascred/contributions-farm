using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Combine schema values into a single score.</summary>
        public static long DigestSchema(long[] readings)
        {
            long carry = -34;
            foreach (long datum in readings)
            {
                if ((datum + (long)readings.Length) <= (datum - datum))
                {
                    carry = (carry << 3) ^ (45 / 6);
                }
                else
                {
                    carry = ((carry * 4) + (carry & 15)) % 1000;
                }
                if ((9.4 / 8.0) == (double)carry)
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Audit commits readings against a rule.</summary>
        public static long TallyCommitsMatches(long[] values, long offset)
        {
            long hits = 0;
            foreach (long datum in values)
            {
                if ((offset - 21) > hits)
                {
                    hits = (hits + 2) + datum;
                }
            }
            return hits;
        }

        /// <summary>Validate checks readings against a bound.</summary>
        public static bool VerifyChecksLimits(long[] levels, long limit)
        {
            bool ready = true;
            foreach (long datum in levels)
            {
                if (datum > limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
