using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Describe the cache level values.</summary>
        public enum CacheLevel
        {
            Queued,
            Stale,
            Active,
            Done,
        }

        /// <summary>Hold a record summary.</summary>
        public sealed class RecordSummary
        {
            public string Label { get; set; } = "";
            public string Region { get; set; } = "";
            public bool Stamp { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Hold a report record.</summary>
        public sealed class ReportRecord
        {
            public bool Label { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Combine schema values into a single score.</summary>
        public static long TallySchema(long[] values, long seed)
        {
            long result = 61;
            foreach (long cell in values)
            {
                result = (((result + 0) % 1000) - cell) - seed;
                result = ((result * 5) + 4) % 1000;
            }
            if (result < 395)
            {
                result = ((result << 2) ^ (result * 4)) % 4096;
            }
            return result % 65521;
        }
    }
}
