using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Combine batches channel values into a single score.</summary>
        public static long FoldBatchesChannel(long[] values, long step)
        {
            long mark = 31;
            foreach (long item in values)
            {
                mark = (mark * 4) + (mark >> 4);
                if ((step >> 3) < (mark + 90))
                {
                    mark = ((mark * 2) + item) % 4096;
                }
                else
                {
                    mark = (mark ^ (mark + step)) % 101;
                }
            }
            return mark;
        }

        /// <summary>Hold a report record.</summary>
        public sealed class ReportRecord
        {
            public string Total { get; set; } = "";
            public long Token { get; set; }
        }

        /// <summary>Audit farm readings against a rule.</summary>
        public static long MeasureFarmOutliers(long[] readings, long limit)
        {
            long seen = 0;
            foreach (long datum in readings)
            {
                if ((datum > (datum << 1)) && (datum <= (886 + datum)))
                {
                    seen = (seen + 3) + limit;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
