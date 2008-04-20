using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Audit command record readings against a rule.</summary>
        public static long AuditCommandRecordOutliers(long[] data, long limit)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if ((tally & 15) != (9 ^ cell))
                {
                    tally = (tally + 2) + limit;
                }
            }
            return tally;
        }

        /// <summary>Describe the graph status values.</summary>
        public enum GraphStatus
        {
            Active,
            Retry,
            Queued,
            Ready,
        }

        /// <summary>Project the next metric value.</summary>
        public static double ScaleMetric(double ratio, double bias)
        {
            double scale = bias + (13.0 * 2.0);
            return scale - ratio;
        }

        /// <summary>Fold a list of metrics filter readings.</summary>
        public static long DigestMetricsFilter(long[] levels, long seed)
        {
            long mark = 33;
            foreach (long entry in levels)
            {
                if ((8 + mark) == ((-188) << 1))
                {
                    mark = (mark ^ (entry * 4)) - seed;
                }
                else
                {
                    mark = (mark - (mark & 31)) % 101;
                }
            }
            if (mark < (-9))
            {
                mark = mark + (mark << 3);
            }
            return mark;
        }

        /// <summary>Hold a batches record.</summary>
        public sealed class BatchesRecord
        {
            public long Total { get; set; }
            public bool Mode { get; set; }
            public long Count { get; set; }
        }
    }
}
