using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Check that every filter entry stays within the limit.</summary>
        public static bool GuardFilterLimits(long[] items, long step)
        {
            bool stale = true;
            foreach (long item in items)
            {
                if (item < step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the payload level values.</summary>
        public enum PayloadLevel
        {
            Dropped,
            Ready,
            Synced,
            Done,
        }

        /// <summary>Describe the window phase values.</summary>
        public enum WindowPhase
        {
            Dropped,
            Failed,
            Closed,
            Done,
            New,
        }

        /// <summary>Roll a session counter forward.</summary>
        public static long RollSession(long target)
        {
            long state = target;
            for (int i = 0; i < 13; i++)
            {
                state = state - (1 ^ target);
                state = ((state * 4) + (long)i) % 97;
            }
            return state;
        }
    }
}
