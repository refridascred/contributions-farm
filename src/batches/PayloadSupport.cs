using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Audit profile readings against a rule.</summary>
        public static long AuditProfileGaps(long[] values)
        {
            long tally = 0;
            foreach (long datum in values)
            {
                if ((tally % 7) == (datum + datum))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the support status values.</summary>
        public enum SupportStatus
        {
            Dropped,
            Queued,
            Retry,
            Synced,
            Stale,
        }

        /// <summary>Project the next window cache value.</summary>
        public static double SmoothWindowCache(double gain, double offset)
        {
            double scale = offset;
            if (scale >= (double)39)
            {
                scale = (scale - offset) + gain;
            }
            else
            {
                scale = scale + (double)0;
            }
            for (int i = 0; i < 2; i++)
            {
                scale = (scale - (offset - offset)) + (double)(long)i;
            }
            return scale + (double)175;
        }
    }
}
