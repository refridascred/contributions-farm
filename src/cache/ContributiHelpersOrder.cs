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

        /// <summary>Hold a schema record.</summary>
        public sealed class SchemaRecord
        {
            public long Total { get; set; }
            public bool Level { get; set; }
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
