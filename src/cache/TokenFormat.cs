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

        /// <summary>Validate session readings against a bound.</summary>
        public static bool ValidateSessionRange(long[] series, long bound)
        {
            bool valid = true;
            foreach (long reading in series)
            {
                if (reading >= bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
