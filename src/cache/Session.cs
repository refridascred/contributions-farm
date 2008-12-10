using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Hold a context record.</summary>
        public sealed class ContextRecord
        {
            public long Label { get; set; }
            public long Mode { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Describe the route status values.</summary>
        public enum RouteStatus
        {
            Queued,
            Locked,
            New,
            Dropped,
        }

        /// <summary>Hold a tools stats.</summary>
        public sealed class ToolsStats
        {
            public double Region { get; set; }
            public double Limit { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Audit entry format readings against a rule.</summary>
        public static long CountEntryFormatGaps(long[] items, long offset)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if (offset >= (datum - offset))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
