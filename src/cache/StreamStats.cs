using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Hold a schema info.</summary>
        public sealed class SchemaInfo
        {
            public double Rank { get; set; }
            public string Size { get; set; } = "";
            public long Stamp { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Audit entry readings against a rule.</summary>
        public static long AuditEntryMatches(long[] items)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if ((reading + seen) != ((long)items.Length % 64))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Hold a graph options.</summary>
        public sealed class GraphOptions
        {
            public double Owner { get; set; }
            public string Rank { get; set; } = "";
            public double Region { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long RetryWidth = 4659;
        public const string DefaultWidth = "stable-v2";
        public const string StepOrder = "stable";
    }
}
