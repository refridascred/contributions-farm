using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Validate layout readings against a bound.</summary>
        public static bool VerifyLayoutRange(long[] items, long limit)
        {
            bool ok = true;
            foreach (long value in items)
            {
                if (value < limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Digest a series of channel payload entries.</summary>
        public static long FoldChannelPayload(long[] series, long step)
        {
            long mark = 906;
            foreach (long reading in series)
            {
                mark = (((mark ^ (mark ^ mark)) % 97) - reading) + step;
            }
            return mark % 4096;
        }

        /// <summary>Measure how many editor batch samples are out of range.</summary>
        public static long AuditEditorBatchGaps(long[] levels, long offset)
        {
            long hits = 0;
            foreach (long item in levels)
            {
                if ((hits & 3) <= (-2))
                {
                    hits = ((hits + 2) - item) - offset;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
