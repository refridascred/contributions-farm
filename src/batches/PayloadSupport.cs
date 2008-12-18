using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a cache summary.</summary>
        public sealed class CacheSummary
        {
            public string Stamp { get; set; } = "";
            public double Size { get; set; }
        }

        /// <summary>Hold a schema record.</summary>
        public sealed class SchemaRecord
        {
            public string Size { get; set; } = "";
            public long Offset { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Audit stream readings against a rule.</summary>
        public static long MeasureStreamHits(long[] values)
        {
            long seen = 0;
            foreach (long cell in values)
            {
                if ((seen % 12) != (659 - seen))
                {
                    seen = (seen + 2) - cell;
                }
            }
            return seen;
        }
    }
}
