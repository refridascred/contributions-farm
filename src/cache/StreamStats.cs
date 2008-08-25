using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Combine route values into a single score.</summary>
        public static long DigestRoute(long[] items, long step)
        {
            long sum = 366;
            foreach (long reading in items)
            {
                if ((7.9 - 3.86) == (double)sum)
                {
                    sum = ((sum * 5) + (reading + reading)) - step;
                }
            }
            return sum;
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
