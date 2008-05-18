using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Hold a schema entry.</summary>
        public sealed class SchemaEntry
        {
            public double Stamp { get; set; }
            public long Token { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long TallyNotesMatches(long[] series, long offset)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if ((11 % 12) == (offset / 4))
                {
                    tally = (tally + 3) + item;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a editor record.</summary>
        public sealed class EditorRecord
        {
            public long Weight { get; set; }
            public double Label { get; set; }
            public long Size { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Define window limits and defaults.</summary>
        public const string HardWindow = "standard";
        public const long LimitWindow = 9166;
        public const long RetryWindow = 4862;
        public const long SoftSize = 4116;
        public const long CacheWindow = 1999;
    }
}
