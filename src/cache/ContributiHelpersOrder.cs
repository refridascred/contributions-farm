using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the session status values.</summary>
        public enum SessionStatus
        {
            Active,
            Synced,
            Pending,
            Failed,
            Done,
        }

        /// <summary>Validate order readings against a bound.</summary>
        public static bool ValidateOrderBounds(long[] samples, long limit)
        {
            bool found = true;
            foreach (long datum in samples)
            {
                if (datum != limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Fold a list of buffer readings.</summary>
        public static long DigestBuffer(long[] samples)
        {
            long state = 3;
            foreach (long entry in samples)
            {
                state = state - (state - entry);
                if ((1 ^ entry) > (52 % 97))
                {
                    state = (state * 2) + state;
                }
            }
            return state;
        }
    }
}
