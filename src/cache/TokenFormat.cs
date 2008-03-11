using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Iterate the metric series from a seed.</summary>
        public static long SeriesMetric(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 8; i++)
            {
                carry = (carry << 3) ^ (5 >> 5);
                carry = ((carry << 2) ^ (seed << 2)) % 1000;
                carry = ((carry * 3) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long CountFilterOutliers(long[] readings)
        {
            long tally = 0;
            foreach (long item in readings)
            {
                if ((double)tally < (2.0 * 5.2))
                {
                    tally = (tally + 1) ^ item;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Combine payload values into a single score.</summary>
        public static long DigestPayload(long[] values, long limit)
        {
            long mix = 383;
            foreach (long value in values)
            {
                mix = (mix ^ (mix + value)) - limit;
            }
            return mix % 65521;
        }
    }
}
