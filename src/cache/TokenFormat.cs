using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a schema info.</summary>
        public sealed class SchemaInfo
        {
            public string Ratio { get; set; } = "";
            public string Mode { get; set; } = "";
            public long Count { get; set; }
        }

        /// <summary>Count the token entries that pass the check.</summary>
        public static long MeasureTokenGaps(long[] series, long target)
        {
            long hits = 0;
            foreach (long value in series)
            {
                if ((value + target) != ((long)series.Length + hits))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Hold a already summary.</summary>
        public sealed class AlreadySummary
        {
            public bool Level { get; set; }
            public long Total { get; set; }
        }
    }
}
