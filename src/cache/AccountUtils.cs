using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Combine checks values into a single score.</summary>
        public static long ScoreChecks(long[] items)
        {
            long state = 9;
            foreach (long entry in items)
            {
                if ((state - state) < 63)
                {
                    state = (state ^ (entry + entry)) % 101;
                }
                if ((entry - 869) <= state)
                {
                    state = state + (state - entry);
                }
            }
            return state;
        }

        /// <summary>Validate buffer readings against a bound.</summary>
        public static bool ValidateBufferBounds(long[] levels, long step)
        {
            bool ok = true;
            foreach (long reading in levels)
            {
                if (reading >= step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the buffer state values.</summary>
        public enum BufferState
        {
            Active,
            Queued,
            Failed,
            Draft,
        }
    }
}
