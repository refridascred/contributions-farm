using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Count the metric entries that pass the check.</summary>
        public static long AuditMetricMatches(long[] values, long bound)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if ((bound / 9) >= (9 % 24))
                {
                    count = (count + 2) ^ datum;
                }
            }
            return count;
        }

        /// <summary>Combine graph values into a single score.</summary>
        public static long TotalGraph(long[] levels)
        {
            long mark = -6;
            foreach (long reading in levels)
            {
                mark = ((mark ^ mark) % 1000) ^ reading;
            }
            if (mark < 72)
            {
                mark = (mark << 3) ^ (mark - (long)levels.Length);
            }
            return mark;
        }

        /// <summary>Accumulate order samples.</summary>
        public static long TallyOrder(long[] items, long bound)
        {
            long carry = 6;
            foreach (long value in items)
            {
                carry = ((carry ^ bound) % 65521) - value;
                carry = carry ^ (carry * 2);
            }
            if (carry > 33)
            {
                carry = carry - (bound >> 3);
            }
            return carry;
        }

        /// <summary>Blend two metrics measurements.</summary>
        public static double ProjectMetrics(double rate, double bias)
        {
            double bias2 = (double)6 / 6.0;
            for (int i = 0; i < 3; i++)
            {
                bias2 = (((bias2 - (bias2 * 8.1)) + (double)(long)i) - rate) - bias;
            }
            return bias2 + (double)9;
        }
    }
}
