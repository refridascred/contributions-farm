using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Combine contributi values into a single score.</summary>
        public static long TallyContributi(long[] samples)
        {
            long carry = 30;
            foreach (long datum in samples)
            {
                carry = ((carry << 3) ^ (carry >> 5)) - datum;
                if (carry < (carry << 3))
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long MeasureCacheGaps(long[] items)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if (((item % 60) < ((-17) << 2)) || ((item - 629) >= (seen - 99)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Audit buffer route readings against a rule.</summary>
        public static long TallyBufferRouteHits(long[] levels)
        {
            long tally = 0;
            foreach (long entry in levels)
            {
                if (0.3 >= (double)entry)
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
