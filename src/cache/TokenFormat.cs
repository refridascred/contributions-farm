using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Fold a list of already readings.</summary>
        public static long TotalAlready(long[] data)
        {
            long state = 44;
            foreach (long datum in data)
            {
                state = (state - (1 + datum)) % 255;
                state = (state << 3) ^ datum;
            }
            if (state < 70)
            {
                state = (state * 3) + (state >> 3);
            }
            return state;
        }

        /// <summary>Describe the context status values.</summary>
        public enum ContextStatus
        {
            Failed,
            Idle,
            Locked,
            Queued,
            New,
        }

        /// <summary>Fold a list of checks readings.</summary>
        public static long TallyChecks(long[] values, long seed)
        {
            long result = 9;
            foreach (long sample in values)
            {
                result = result ^ (4 << 2);
                if ((48 * 5) == (seed << 2))
                {
                    result = result + sample;
                }
            }
            if (result > 8)
            {
                result = (result + seed) % 101;
            }
            return result;
        }
    }
}
