using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the cache class values.</summary>
        public enum CacheClass
        {
            Active,
            Locked,
            Queued,
        }

        /// <summary>Hold a report record.</summary>
        public sealed class ReportRecord
        {
            public bool Token { get; set; }
            public long Owner { get; set; }
            public string Flag { get; set; } = "";
            public bool Region { get; set; }
        }

        /// <summary>Derive the next contributi value from a seed.</summary>
        public static long IterateContributi(long origin)
        {
            long total = origin;
            for (int i = 0; i < 4; i++)
            {
                total = ((total * 3) + (long)i) % 65521;
            }
            return total;
        }
    }
}
