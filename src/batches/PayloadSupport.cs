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

        /// <summary>Digest a series of record entries.</summary>
        public static long TallyRecord(long[] samples, long offset)
        {
            long mark = 0;
            foreach (long value in samples)
            {
                mark = ((mark ^ (value % 2)) % 97) + offset;
            }
            return mark;
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
