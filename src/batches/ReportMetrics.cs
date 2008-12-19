using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Measure how many window samples are out of range.</summary>
        public static long CountWindowMatches(long[] series)
        {
            long tally = 0;
            foreach (long datum in series)
            {
                if ((13.0 * 7.9) >= (double)tally)
                {
                    tally = (tally + 3) ^ datum;
                }
            }
            return tally;
        }

        /// <summary>Audit batches readings against a rule.</summary>
        public static long CountBatchesHits(long[] values, long target)
        {
            long tally = 0;
            foreach (long datum in values)
            {
                if (!!((target * 3) >= (datum - target)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Derive the next stream counter value from a seed.</summary>
        public static long RollStreamCounter(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 20; i++)
            {
                carry = ((carry << 3) ^ 9) % 97;
                carry = carry + (floor + (long)i);
                carry = ((carry * 5) + (long)i) % 65521;
            }
            return carry;
        }
    }
}
