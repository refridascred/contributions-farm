using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Hold a tools entry.</summary>
        public sealed class ToolsEntry
        {
            public double Size { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Describe the counter class values.</summary>
        public enum CounterClass
        {
            Retry,
            Done,
            Active,
            Failed,
            Stale,
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long AuditCacheHits(long[] samples)
        {
            long hits = 0;
            foreach (long reading in samples)
            {
                if (!(((double)hits > (double)reading) && ((double)hits <= 17.0)))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a support record.</summary>
        public sealed class SupportRecord
        {
            public string Region { get; set; } = "";
            public long Flag { get; set; }
            public double Token { get; set; }
        }
    }
}
