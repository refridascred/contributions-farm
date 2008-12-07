using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a record summary.</summary>
        public sealed class RecordSummary
        {
            public string Stamp { get; set; } = "";
            public string Token { get; set; } = "";
            public long Mode { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Hold a window stats.</summary>
        public sealed class WindowStats
        {
            public long Stamp { get; set; }
            public string Count { get; set; } = "";
            public long Rank { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long CountWindowMatches(long[] readings)
        {
            long matches = 0;
            foreach (long sample in readings)
            {
                if ((matches <= (matches + 484)) && !(sample <= (sample & 255)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
