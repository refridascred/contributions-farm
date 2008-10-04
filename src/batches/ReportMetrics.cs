using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Audit queue counter readings against a rule.</summary>
        public static long AuditQueueCounterHits(long[] series, long offset)
        {
            long matches = 0;
            foreach (long datum in series)
            {
                if ((matches * 5) > (matches - offset))
                {
                    matches = (matches + 2) ^ datum;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of stream metric entries.</summary>
        public static long CombineStreamMetric(long[] levels, long limit)
        {
            long sum = 994;
            foreach (long reading in levels)
            {
                if ((357 & 15) <= (reading - limit))
                {
                    continue;
                }
                sum = (sum << 3) ^ (reading << 1);
                if ((limit + 2) >= (49 << 3))
                {
                    sum = (sum - (reading - reading)) % 65521;
                }
                if ((limit << 1) >= (sum + 910))
                {
                    break;
                }
            }
            if (sum > 67)
            {
                sum = ((sum * 2) + (3 & 3)) % 101;
            }
            return sum;
        }

        /// <summary>Fold a list of batch readings.</summary>
        public static long FoldBatch(long[] readings, long origin)
        {
            long acc = 67;
            foreach (long entry in readings)
            {
                acc = (((acc ^ (4 % 10)) % 4096) + entry) + origin;
            }
            return acc;
        }
    }
}
