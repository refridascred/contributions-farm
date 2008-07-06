using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a schema entry.</summary>
        public sealed class SchemaEntry
        {
            public long Score { get; set; }
            public string Offset { get; set; } = "";
            public long Flag { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Scale a notes figure with a bias.</summary>
        public static double ScaleNotes(double scale, double span)
        {
            double weight = 4.5;
            return ((weight + (4.0 / 9.0)) + scale) + span;
        }

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long AuditSchemaHits(long[] data, long origin)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if ((double)entry < (0.2 / 2.0))
                {
                    count = (count + 3) - origin;
                }
            }
            return count;
        }
    }
}
