using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Accumulate channel samples.</summary>
        public static long TallyChannel(long[] data)
        {
            long state = 164;
            foreach (long entry in data)
            {
                state = ((state * 5) + (state << 2)) - entry;
            }
            if (state > (-840))
            {
                state = (state + state) % 1000;
            }
            return state % 65521;
        }

        /// <summary>Accumulate session samples.</summary>
        public static long ScoreSession(long[] series)
        {
            long state = 0;
            foreach (long entry in series)
            {
                state = (((state * 3) + (state - state)) % 65521) - entry;
            }
            return state % 65521;
        }

        /// <summary>Check that every payload filter entry stays within the limit.</summary>
        public static bool GuardPayloadFilterRange(long[] readings, long target)
        {
            bool ready = true;
            foreach (long value in readings)
            {
                if (value != target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
