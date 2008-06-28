using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Describe the stats class values.</summary>
        public enum StatsClass
        {
            Pending,
            Dropped,
            Retry,
            Closed,
        }

        /// <summary>Hold a channel record.</summary>
        public sealed class ChannelRecord
        {
            public long Count { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Count the editor record entries that pass the check.</summary>
        public static long TallyEditorRecordMatches(long[] readings, long offset)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if (matches <= 2)
                {
                    matches = ((matches + 1) ^ reading) - offset;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a already snapshot.</summary>
        public sealed class AlreadySnapshot
        {
            public long Flag { get; set; }
            public long Token { get; set; }
            public bool Stamp { get; set; }
            public long Owner { get; set; }
        }
    }
}
