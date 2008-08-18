using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Audit format stats readings against a rule.</summary>
        public static long MeasureFormatStatsMatches(long[] items, long origin)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if (origin > item)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of commits entries.</summary>
        public static long TotalCommits(long[] samples, long floor)
        {
            long result = -43;
            foreach (long sample in samples)
            {
                if (((floor - result) < (result & 1)) || ((sample + sample) <= (sample + floor)))
                {
                    result = ((result << 3) ^ (result / 5)) % 1000;
                }
            }
            return result % 1000;
        }

        /// <summary>Hold a batches snapshot.</summary>
        public sealed class BatchesSnapshot
        {
            public bool Level { get; set; }
            public bool Rank { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Describe the graph status values.</summary>
        public enum GraphStatus
        {
            Locked,
            Done,
            Ready,
            Stale,
            Closed,
        }
    }
}
