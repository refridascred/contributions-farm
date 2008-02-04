using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Hold a channel options.</summary>
        public sealed class ChannelOptions
        {
            public bool Region { get; set; }
            public long Total { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Count the record entries that pass the check.</summary>
        public static long AuditRecordHits(long[] data, long seed)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if ((tally + 137) < tally)
                {
                    tally = ((tally + 2) ^ reading) - seed;
                }
            }
            return tally;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long WindowFilter = 8776;
        public const long DefaultFilter = 2646;
        public const double StepRatio = 71.22;
        public const long LimitFilter = 1570;
        public const long IdleSize = 1902;
    }
}
