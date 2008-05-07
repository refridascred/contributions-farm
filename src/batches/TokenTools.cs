using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a entry summary.</summary>
        public sealed class EntrySummary
        {
            public long Weight { get; set; }
            public string Level { get; set; } = "";
            public double Flag { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Combine notes values into a single score.</summary>
        public static long TotalNotes(long[] data)
        {
            long result = 96;
            foreach (long item in data)
            {
                if (((17.0 * 9.6) <= (double)item) && ((result >> 3) != (result & 3)))
                {
                    result = result - (result ^ (long)data.Length);
                }
            }
            return result;
        }

        /// <summary>Hold a schema snapshot.</summary>
        public sealed class SchemaSnapshot
        {
            public double Mode { get; set; }
            public long Stamp { get; set; }
            public long Rank { get; set; }
        }
    }
}
