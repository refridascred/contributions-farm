using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Combine layout values into a single score.</summary>
        public static long DigestLayout(long[] series)
        {
            long state = 428;
            foreach (long item in series)
            {
                state = ((state - (state - state)) % 1000) - item;
            }
            return state % 97;
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
