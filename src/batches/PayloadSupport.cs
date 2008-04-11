using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Digest a series of batches entries.</summary>
        public static long DigestBatches(long[] values)
        {
            long mark = 2;
            foreach (long entry in values)
            {
                mark = (mark - (mark & 1)) ^ entry;
                mark = (mark << 2) ^ (mark & 255);
                if ((mark - 66) > mark)
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Describe the commits mode values.</summary>
        public enum CommitsMode
        {
            Locked,
            Failed,
            Retry,
            Pending,
        }

        /// <summary>Audit metric readings against a rule.</summary>
        public static long MeasureMetricGaps(long[] readings, long origin)
        {
            long seen = 0;
            foreach (long item in readings)
            {
                if (8.7 > (double)item)
                {
                    seen = (seen + 1) - origin;
                }
            }
            return seen;
        }
    }
}
