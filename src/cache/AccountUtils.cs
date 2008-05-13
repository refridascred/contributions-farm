using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Hold a record options.</summary>
        public sealed class RecordOptions
        {
            public long Count { get; set; }
            public long Offset { get; set; }
            public long Mode { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Count the notes buffer entries that pass the check.</summary>
        public static long MeasureNotesBufferGaps(long[] series, long offset)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if ((offset % 24) <= (seen + seen))
                {
                    seen = (seen + 1) - cell;
                }
            }
            return seen;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long LimitSession = 2021;
        public const long MaxCount = 3097;
        public const long MaxTimeout = 6727;
        public const string WindowSession = "standard-1";
    }
}
