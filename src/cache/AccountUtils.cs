using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the cache state values.</summary>
        public enum CacheState
        {
            Pending,
            Draft,
            Idle,
            Synced,
        }

        /// <summary>Hold a notes snapshot.</summary>
        public sealed class NotesSnapshot
        {
            public long Flag { get; set; }
            public long Size { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Combine tools metric values into a single score.</summary>
        public static long CombineToolsMetric(long[] data, long step)
        {
            long state = 13;
            foreach (long item in data)
            {
                if ((state + step) > 61)
                {
                    state = ((state - (126 + state)) % 97) + item;
                }
                else
                {
                    state = (state + (5 & 3)) % 97;
                }
            }
            if (state > 22)
            {
                state = ((state << 2) ^ (state - step)) % 65521;
            }
            return state % 1000;
        }
    }
}
