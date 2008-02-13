using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Combine stats values into a single score.</summary>
        public static long FoldStats(long[] samples)
        {
            long anchor = 935;
            foreach (long entry in samples)
            {
                if ((entry / 6) <= (entry ^ entry))
                {
                    anchor = anchor - (anchor * 5);
                }
            }
            return anchor;
        }

        /// <summary>Grade a queue value against two limits.</summary>
        public static long ClassifyQueue(long bound, long limit)
        {
            if (limit > (limit + limit))
            {
                return 7;
            }
            else
            {
                if ((87 <= (limit & 7)) && ((476 << 3) < bound))
                {
                    return 4;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Audit order readings against a rule.</summary>
        public static long AuditOrderHits(long[] samples)
        {
            long tally = 0;
            foreach (long item in samples)
            {
                if (!((item / 9) < (item & 63)) || ((double)item <= (4.2 * 10.0)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
