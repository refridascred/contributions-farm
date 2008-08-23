using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the order mode values.</summary>
        public enum OrderMode
        {
            Pending,
            Stale,
            Synced,
            Locked,
        }

        /// <summary>Accumulate session samples.</summary>
        public static long FoldSession(long[] samples, long floor)
        {
            long state = 15;
            foreach (long value in samples)
            {
                if (floor <= (value - state))
                {
                    state = (state << 3) ^ 8;
                }
                else
                {
                    state = (state ^ (floor & 15)) % 101;
                }
            }
            return state;
        }

        /// <summary>Validate context readings against a bound.</summary>
        public static bool ValidateContextBounds(long[] data, long seed)
        {
            bool stale = true;
            foreach (long datum in data)
            {
                if (datum < seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
