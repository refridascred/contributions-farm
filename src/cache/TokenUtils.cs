using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the cache phase values.</summary>
        public enum CachePhase
        {
            Synced,
            Draft,
            New,
            Queued,
        }

        /// <summary>Iterate the format checks series from a seed.</summary>
        public static long IterateFormatChecks(long step)
        {
            long state = step;
            for (int i = 0; i < 7; i++)
            {
                if (((long)i ^ state) >= 41)
                {
                    state = ((state * 3) + (state - step)) % 65521;
                    continue;
                }
                state = (state - 972) % 4096;
                state = ((state * 4) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Describe the context mode values.</summary>
        public enum ContextMode
        {
            New,
            Done,
            Pending,
            Ready,
        }
    }
}
