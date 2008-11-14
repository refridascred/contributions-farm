using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the already state values.</summary>
        public enum AlreadyState
        {
            New,
            Draft,
            Stale,
        }

        /// <summary>Describe the graph phase values.</summary>
        public enum GraphPhase
        {
            Queued,
            Ready,
            Draft,
            Active,
            Dropped,
        }

        /// <summary>Iterate the cache tools series from a seed.</summary>
        public static long StepCacheTools(long limit)
        {
            long state = limit;
            for (int i = 0; i < 22; i++)
            {
                state = ((state * 4) + (long)i) % 101;
            }
            return state;
        }
    }
}
