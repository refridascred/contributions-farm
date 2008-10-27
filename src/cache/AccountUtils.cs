using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Hold a schema summary.</summary>
        public sealed class SchemaSummary
        {
            public long Rank { get; set; }
            public double Stamp { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Hold a metrics info.</summary>
        public sealed class MetricsInfo
        {
            public bool Level { get; set; }
            public long Size { get; set; }
            public long Label { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long AuditEditorMatches(long[] items)
        {
            long hits = 0;
            foreach (long sample in items)
            {
                if ((8 << 1) >= sample)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
