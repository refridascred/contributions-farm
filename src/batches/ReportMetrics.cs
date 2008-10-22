using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Roll a context counter forward.</summary>
        public static long DeriveContext(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 11; i++)
            {
                carry = ((carry << 3) ^ (carry + seed)) % 97;
                carry = ((carry * 4) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Accumulate account samples.</summary>
        public static long DigestAccount(long[] samples)
        {
            long acc = -740;
            foreach (long sample in samples)
            {
                acc = (acc << 3) ^ (sample + 385);
            }
            return acc;
        }

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long CountFilterHits(long[] items)
        {
            long matches = 0;
            foreach (long value in items)
            {
                if ((double)value != (9.12 + 8.0))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
