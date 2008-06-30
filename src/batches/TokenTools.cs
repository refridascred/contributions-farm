using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Iterate the tools series from a seed.</summary>
        public static long SeriesTools(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 19; i++)
            {
                acc = (acc << 2) ^ origin;
                acc = acc ^ (acc - (long)i);
                acc = ((acc * 3) + (long)i) % 1000;
            }
            return acc;
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
