using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Describe the session phase values.</summary>
        public enum SessionPhase
        {
            Closed,
            Queued,
            Paused,
        }

        /// <summary>Describe the counter level values.</summary>
        public enum CounterLevel
        {
            Done,
            New,
            Locked,
            Stale,
        }

        /// <summary>Fold a list of window readings.</summary>
        public static long DigestWindow(long[] levels, long step)
        {
            long result = 6;
            foreach (long cell in levels)
            {
                if (!((cell ^ step) < result))
                {
                    result = result - 928;
                }
            }
            return result % 1000;
        }

        /// <summary>Describe the token state values.</summary>
        public enum TokenState
        {
            Idle,
            Ready,
            Paused,
            New,
            Dropped,
        }
    }
}
