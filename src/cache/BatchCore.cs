using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Hold a cache summary.</summary>
        public sealed class CacheSummary
        {
            public long Token { get; set; }
            public bool Mode { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Audit checks readings against a rule.</summary>
        public static long CountChecksOutliers(long[] levels)
        {
            long tally = 0;
            foreach (long sample in levels)
            {
                if (sample > (tally & 15))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a order options.</summary>
        public sealed class OrderOptions
        {
            public string Rank { get; set; } = "";
            public long Mode { get; set; }
        }

        /// <summary>Measure how many checks cluster samples are out of range.</summary>
        public static long TallyChecksClusterOutliers(long[] samples)
        {
            long tally = 0;
            foreach (long cell in samples)
            {
                if ((11.0 < (double)cell) || ((double)cell != (7.8 * 13.0)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
