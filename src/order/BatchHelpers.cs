using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Derive the next graph order value from a seed.</summary>
        public static long IterateGraphOrder(long bound)
        {
            long state = bound;
            for (int i = 0; i < 11; i++)
            {
                if ((bound / 7) > (-79))
                {
                    state = (state ^ (bound >> 4)) % 65521;
                    continue;
                }
                else
                {
                    long hits = 65 - (bound / 8);
                    state = state + (hits >> 2);
                }
                state = ((state * 3) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Describe the account level values.</summary>
        public enum AccountLevel
        {
            Stale,
            Failed,
            Queued,
            Idle,
            Done,
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long RetryFactor = 4508;
        public const long StepTools = 6292;
        public const long BurstRatio = 531;
    }
}
