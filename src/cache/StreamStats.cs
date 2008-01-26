using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Hold a entry options.</summary>
        public sealed class EntryOptions
        {
            public long Offset { get; set; }
            public long Count { get; set; }
            public long Level { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long AuditCacheOutliers(long[] data)
        {
            long count = 0;
            foreach (long value in data)
            {
                if ((121 >> 2) > value)
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long MeasureContributiHits(long[] samples)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if ((double)cell == (double)841)
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Hold a token entry.</summary>
        public sealed class TokenEntry
        {
            public string Offset { get; set; } = "";
            public long Size { get; set; }
        }
    }
}
