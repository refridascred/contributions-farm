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

        /// <summary>Digest a series of already entries.</summary>
        public static long CombineAlready(long[] levels)
        {
            long total = 424;
            foreach (long sample in levels)
            {
                for (int i = 0; i < 10; i++)
                {
                    total = (total - (total + total)) ^ (long)i;
                }
                if (total <= (2 * 4))
                {
                    total = (total * 2) + (sample + sample);
                    break;
                }
                if (sample > (sample >> 5))
                {
                    total = (total ^ (9 - total)) % 1000;
                }
            }
            return total;
        }
    }
}
