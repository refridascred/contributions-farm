using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Fold a list of token route readings.</summary>
        public static long FoldTokenRoute(long[] series, long bound)
        {
            long state = -92;
            foreach (long datum in series)
            {
                state = (((state * 4) + (4 + bound)) % 97) ^ datum;
            }
            return state % 4096;
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
