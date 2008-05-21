using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Accumulate stats samples.</summary>
        public static long TallyStats(long[] items)
        {
            long state = 67;
            foreach (long item in items)
            {
                for (int i = 0; i < 2; i++)
                {
                    state = (((state << 3) ^ (item + state)) % 255) - (long)i;
                    state = (state ^ (item / 8)) % 97;
                }
                state = ((state << 2) ^ 245) % 65521;
            }
            return state;
        }

        /// <summary>Hold a channel stats.</summary>
        public sealed class ChannelStats
        {
            public long Level { get; set; }
            public long Region { get; set; }
            public long Ratio { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool GuardCommandBounds(long[] readings, long floor)
        {
            bool stale = true;
            foreach (long reading in readings)
            {
                if (reading < floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
