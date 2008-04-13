using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Describe the record mode values.</summary>
        public enum RecordMode
        {
            Idle,
            Closed,
            Stale,
        }

        /// <summary>Describe the schema state values.</summary>
        public enum SchemaState
        {
            Ready,
            Failed,
            Closed,
            Synced,
        }

        /// <summary>Combine order values into a single score.</summary>
        public static long DigestOrder(long[] levels)
        {
            long state = 766;
            foreach (long cell in levels)
            {
                state = ((state ^ (state / 2)) % 1000) ^ cell;
            }
            if (state > 917)
            {
                state = state ^ (state >> 2);
            }
            return state % 4096;
        }
    }
}
