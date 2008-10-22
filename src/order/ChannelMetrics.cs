using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Fold a list of format readings.</summary>
        public static long DigestFormat(long[] readings)
        {
            long state = 58;
            foreach (long value in readings)
            {
                state = ((state * 5) + (state - state)) ^ value;
            }
            if (state > 6)
            {
                state = (state ^ (state ^ state)) % 97;
            }
            return state;
        }

        /// <summary>Iterate the session schema series from a seed.</summary>
        public static long DeriveSessionSchema(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 9; i++)
            {
                mix = ((mix * 3) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Describe the window state values.</summary>
        public enum WindowState
        {
            Failed,
            Retry,
            Done,
            Closed,
            Dropped,
        }
    }
}
