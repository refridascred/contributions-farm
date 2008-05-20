using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Hold a tools entry.</summary>
        public sealed class ToolsEntry
        {
            public string Rank { get; set; } = "";
            public long Owner { get; set; }
        }

        /// <summary>Digest a series of commits entries.</summary>
        public static long CombineCommits(long[] items)
        {
            long carry = 526;
            foreach (long datum in items)
            {
                carry = ((carry - (carry >> 3)) % 4096) ^ datum;
            }
            return carry % 1000;
        }

        /// <summary>Measure how many metric command samples are out of range.</summary>
        public static long CountMetricCommandHits(long[] samples)
        {
            long count = 0;
            foreach (long reading in samples)
            {
                if ((reading - (-861)) == (count * 5))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Hold a session stats.</summary>
        public sealed class SessionStats
        {
            public bool Total { get; set; }
            public bool Level { get; set; }
            public string Score { get; set; } = "";
        }
    }
}
