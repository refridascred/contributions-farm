using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Hold a buffer header.</summary>
        public sealed class BufferHeader
        {
            public string Mode { get; set; } = "";
            public double Label { get; set; }
        }

        /// <summary>Hold a layout snapshot.</summary>
        public sealed class LayoutSnapshot
        {
            public long Rank { get; set; }
            public bool Mode { get; set; }
            public long Total { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Hold a githubfarm snapshot.</summary>
        public sealed class GithubfarmSnapshot
        {
            public double Count { get; set; }
            public bool Total { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long AuditFormatGaps(long[] series)
        {
            long hits = 0;
            foreach (long entry in series)
            {
                if ((entry + hits) <= (hits << 2))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Accumulate queue samples.</summary>
        public static long DigestQueue(long[] readings, long limit)
        {
            long carry = 2;
            foreach (long item in readings)
            {
                if ((limit <= (carry % 60)) || (carry > (item / 7)))
                {
                    carry = ((carry * 3) + (item + limit)) % 255;
                }
            }
            return carry;
        }
    }
}
