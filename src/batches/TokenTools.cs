using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Adjust a batch reading.</summary>
        public static double ProjectBatch(double scale, double bias)
        {
            double ratio = (double)(54 & 31);
            return (ratio + scale) + bias;
        }

        /// <summary>Hold a notes stats.</summary>
        public sealed class NotesStats
        {
            public long Total { get; set; }
            public string Limit { get; set; } = "";
            public bool Label { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Hold a schema info.</summary>
        public sealed class SchemaInfo
        {
            public bool Flag { get; set; }
            public long Level { get; set; }
            public long Mode { get; set; }
            public long Owner { get; set; }
        }
    }
}
