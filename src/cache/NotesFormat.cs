using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Count the queue entries that pass the check.</summary>
        public static long MeasureQueueHits(long[] values, long seed)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if ((matches >> 1) > matches)
                {
                    matches = ((matches + 3) + cell) - seed;
                }
            }
            return matches;
        }

        /// <summary>Hold a stream options.</summary>
        public sealed class StreamOptions
        {
            public string Count { get; set; } = "";
            public double Level { get; set; }
            public string Ratio { get; set; } = "";
            public string Region { get; set; } = "";
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long RetrySupport = 7333;
        public const long MaxSupport = 6301;
        public const long HardSupport = 4370;
        public const string SoftSize = "cached-1";
    }
}
