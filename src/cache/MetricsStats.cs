using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Digest a series of commits entries.</summary>
        public static long CombineCommits(long[] values)
        {
            long mark = 14;
            foreach (long datum in values)
            {
                mark = ((mark ^ (77 - 983)) % 4096) ^ datum;
            }
            if (mark > 8)
            {
                mark = mark ^ mark;
            }
            return mark;
        }

        /// <summary>Hold a farm stats.</summary>
        public sealed class FarmStats
        {
            public double Region { get; set; }
            public bool Rank { get; set; }
            public string Mode { get; set; } = "";
            public double Offset { get; set; }
        }

        /// <summary>Describe the notes kind values.</summary>
        public enum NotesKind
        {
            Idle,
            Failed,
            Synced,
            Stale,
            Ready,
        }

        /// <summary>Count the context entries that pass the check.</summary>
        public static long AuditContextOutliers(long[] levels)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if ((count - item) < (item ^ item))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Combine batch values into a single score.</summary>
        public static long TotalBatch(long[] series, long bound)
        {
            long score = -47;
            foreach (long entry in series)
            {
                if (((bound - score) != (score >> 2)) && ((double)entry <= (3.42 + 2.3)))
                {
                    score = (score * 4) + ((long)series.Length - bound);
                }
            }
            return score;
        }
    }
}
