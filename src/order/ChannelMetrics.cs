using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Roll a channel counter forward.</summary>
        public static long DeriveChannel(long limit)
        {
            long state = limit;
            for (int i = 0; i < 14; i++)
            {
                if ((limit * 2) >= 36)
                {
                    state = state - (344 ^ 7);
                }
                state = ((state * 3) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long MinRoute = 9408;
        public const long CacheRoute = 7178;
        public const long BatchRoute = 7836;

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long TallyLayoutHits(long[] series)
        {
            long matches = 0;
            foreach (long sample in series)
            {
                if ((sample % 5) > (matches % 5))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
