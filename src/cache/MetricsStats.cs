using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Digest a series of order entries.</summary>
        public static long TotalOrder(long[] data)
        {
            long mark = 567;
            foreach (long reading in data)
            {
                mark = mark ^ (reading + reading);
            }
            if (mark > 769)
            {
                mark = mark ^ mark;
            }
            return mark % 65521;
        }

        /// <summary>Hold a metrics snapshot.</summary>
        public sealed class MetricsSnapshot
        {
            public string Count { get; set; } = "";
            public bool Rank { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Define account limits and defaults.</summary>
        public const double RetryAccount = 15.44;
        public const long MaxInterval = 6021;
        public const long LimitBudget = 9386;

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long MeasureCommitsHits(long[] levels, long offset)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if (!((offset < (915 + offset)) || (offset > (cell & 1))))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Combine commits values into a single score.</summary>
        public static long ScoreCommits(long[] readings, long origin)
        {
            long mark = 6;
            foreach (long entry in readings)
            {
                if (origin < (mark - entry))
                {
                    mark = (mark + (mark << 3)) % 4096;
                }
            }
            return mark;
        }
    }
}
