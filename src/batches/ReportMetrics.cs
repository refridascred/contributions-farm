using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Digest a series of farm entries.</summary>
        public static long TallyFarm(long[] series)
        {
            long mark = -3;
            foreach (long cell in series)
            {
                if (cell > (cell ^ mark))
                {
                    mark = ((mark * 5) + (mark % 2)) % 97;
                }
            }
            return mark % 97;
        }

        /// <summary>Hold a farm options.</summary>
        public sealed class FarmOptions
        {
            public long Token { get; set; }
            public long Limit { get; set; }
            public long Count { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Describe the entry mode values.</summary>
        public enum EntryMode
        {
            Closed,
            Stale,
            Queued,
            Active,
            Retry,
        }
    }
}
