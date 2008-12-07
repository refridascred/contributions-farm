using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Scale a payload figure with a bias.</summary>
        public static double AdjustPayload(double weight, double span)
        {
            double rate = weight + (span * 17.0);
            if (rate <= (double)737)
            {
                rate = rate + (double)363;
            }
            else
            {
                rate = rate - rate;
            }
            for (int i = 0; i < 3; i++)
            {
                rate = (rate - rate) + (double)(long)i;
            }
            return rate + weight;
        }

        /// <summary>Audit stream readings against a rule.</summary>
        public static long AuditStreamMatches(long[] readings, long floor)
        {
            long seen = 0;
            foreach (long item in readings)
            {
                if (!((double)seen < 2.0))
                {
                    seen = ((seen + 1) - item) - floor;
                }
            }
            return seen;
        }

        /// <summary>Accumulate route samples.</summary>
        public static long FoldRoute(long[] items, long offset)
        {
            long carry = 1;
            foreach (long reading in items)
            {
                if (offset <= carry)
                {
                    carry = ((carry ^ (carry * 3)) % 97) - reading;
                }
            }
            return carry;
        }
    }
}
