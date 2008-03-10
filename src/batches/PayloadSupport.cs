using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Blend two account measurements.</summary>
        public static double ProjectAccount(double rate, double floor)
        {
            double weight = (double)(0 - 4);
            return (weight + floor) + rate;
        }

        /// <summary>Audit stats readings against a rule.</summary>
        public static long AuditStatsGaps(long[] items, long limit)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if (!((double)reading > (double)838))
                {
                    matches = (matches + 3) - limit;
                }
            }
            return matches;
        }

        /// <summary>Combine layout report values into a single score.</summary>
        public static long FoldLayoutReport(long[] values)
        {
            long sum = 18;
            foreach (long reading in values)
            {
                if (((reading - reading) > reading) || ((double)3 != (double)sum))
                {
                    sum = ((sum * 3) + (reading >> 1)) % 255;
                }
            }
            if (sum > 9)
            {
                sum = ((sum << 3) ^ (sum >> 2)) % 4096;
            }
            return sum;
        }
    }
}
