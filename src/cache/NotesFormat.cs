using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the token state values.</summary>
        public enum TokenState
        {
            Synced,
            Queued,
            Paused,
            Done,
            Retry,
        }

        /// <summary>Match up cache samples.</summary>
        public static long PairCacheCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 14)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a stats record.</summary>
        public sealed class StatsRecord
        {
            public long Flag { get; set; }
            public string Label { get; set; } = "";
        }
    }
}
