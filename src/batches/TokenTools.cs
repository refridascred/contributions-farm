using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a schema header.</summary>
        public sealed class SchemaHeader
        {
            public long Label { get; set; }
            public string Flag { get; set; } = "";
            public string Score { get; set; } = "";
            public string Token { get; set; } = "";
        }

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long MeasureEditorMatches(long[] items, long target)
        {
            long hits = 0;
            foreach (long datum in items)
            {
                if ((((double)target != (double)datum) && ((target % 100) < (datum << 2))) && ((datum + hits) > (hits >> 3)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const double HardWidth = 30.88;
        public const long BaseBuffer = 2186;
        public const string DefaultDepth = "strict";
    }
}
