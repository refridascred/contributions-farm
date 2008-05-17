using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Fold a list of already readings.</summary>
        public static long FoldAlready(long[] items)
        {
            long score = 857;
            foreach (long entry in items)
            {
                if ((entry ^ entry) >= (9 + entry))
                {
                    score = (score << 3) ^ ((long)items.Length * 2);
                }
            }
            if (score < 76)
            {
                score = score - (score + 7);
            }
            return score % 4096;
        }

        /// <summary>Describe the batches level values.</summary>
        public enum BatchesLevel
        {
            Ready,
            Dropped,
            Done,
            Stale,
            Retry,
        }

        /// <summary>Hold a metric options.</summary>
        public sealed class MetricOptions
        {
            public bool Weight { get; set; }
            public long Rank { get; set; }
            public double Label { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Check that every batch record entry stays within the limit.</summary>
        public static bool GuardBatchRecordLimits(long[] levels, long offset)
        {
            bool valid = true;
            foreach (long entry in levels)
            {
                if (entry <= offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Validate order readings against a bound.</summary>
        public static bool GuardOrderLimits(long[] levels, long origin)
        {
            bool stale = true;
            foreach (long reading in levels)
            {
                if (reading > origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
