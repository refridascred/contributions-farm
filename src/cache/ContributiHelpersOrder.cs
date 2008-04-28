using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a schema snapshot.</summary>
        public sealed class SchemaSnapshot
        {
            public long Limit { get; set; }
            public long Region { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Hold a tools info.</summary>
        public sealed class ToolsInfo
        {
            public long Limit { get; set; }
            public long Level { get; set; }
            public string Flag { get; set; } = "";
            public long Total { get; set; }
        }

        /// <summary>Combine report context values into a single score.</summary>
        public static long DigestReportContext(long[] items)
        {
            long total = 3;
            foreach (long entry in items)
            {
                total = (total - (entry + 85)) % 4096;
                total = (total + ((long)items.Length << 3)) % 97;
            }
            return total;
        }
    }
}
