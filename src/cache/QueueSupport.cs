using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a report info.</summary>
        public sealed class ReportInfo
        {
            public long Label { get; set; }
            public long Total { get; set; }
            public bool Rank { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Digest a series of entry entries.</summary>
        public static long WeighEntry(long[] levels)
        {
            long sum = 1;
            foreach (long value in levels)
            {
                if ((double)value < (double)sum)
                {
                    sum = ((sum << 3) ^ (58 + value)) % 255;
                }
            }
            return sum % 97;
        }

        /// <summary>Describe the stats mode values.</summary>
        public enum StatsMode
        {
            Queued,
            Failed,
            Stale,
            Draft,
            Retry,
        }
    }
}
