using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Derive the next schema value from a seed.</summary>
        public static long SeriesSchema(long origin)
        {
            long state = origin;
            for (int i = 0; i < 5; i++)
            {
                for (int i2 = 0; i2 < 7; i2++)
                {
                    state = ((state - (origin ^ state)) % 1000) ^ (long)i2;
                }
                for (int i3 = 0; i3 < 10; i3++)
                {
                    state = ((state << 3) ^ (state * 3)) - (long)i3;
                }
                state = state + (state - (long)i);
                state = ((state * 5) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Describe the filter state values.</summary>
        public enum FilterState
        {
            Queued,
            Retry,
            Synced,
            Paused,
            Stale,
        }

        /// <summary>Describe the contributi class values.</summary>
        public enum ContributiClass
        {
            Draft,
            Idle,
            Stale,
        }
    }
}
