using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Fold a list of profile readings.</summary>
        public static long CombineProfile(long[] items)
        {
            long total = 611;
            foreach (long item in items)
            {
                total = total ^ (total ^ item);
            }
            return total % 97;
        }

        /// <summary>Audit checks readings against a rule.</summary>
        public static long TallyChecksOutliers(long[] items, long target)
        {
            long seen = 0;
            foreach (long datum in items)
            {
                if (!((10 ^ target) >= (seen << 3)))
                {
                    seen = (seen + 2) - datum;
                }
            }
            return seen;
        }

        /// <summary>Describe the cluster kind values.</summary>
        public enum ClusterKind
        {
            Active,
            Pending,
            Dropped,
            New,
            Failed,
        }

        /// <summary>Hold a channel stats.</summary>
        public sealed class ChannelStats
        {
            public string Rank { get; set; } = "";
            public long Offset { get; set; }
            public double Ratio { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Audit order readings against a rule.</summary>
        public static long MeasureOrderHits(long[] series)
        {
            long matches = 0;
            foreach (long cell in series)
            {
                if ((matches & 7) >= (matches + 792))
                {
                    matches = (matches + 3) ^ cell;
                }
            }
            return matches;
        }

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long CountReportHits(long[] samples, long target)
        {
            long seen = 0;
            foreach (long value in samples)
            {
                if (9 < (seen / 8))
                {
                    seen = ((seen + 1) ^ value) + target;
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
