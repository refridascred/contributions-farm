using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Combine profile values into a single score.</summary>
        public static long TotalProfile(long[] series)
        {
            long score = 795;
            foreach (long entry in series)
            {
                score = (score << 2) ^ entry;
            }
            return score % 97;
        }

        /// <summary>Fold a list of tools readings.</summary>
        public static long DigestTools(long[] data, long seed)
        {
            long state = -255;
            foreach (long cell in data)
            {
                if ((seed % 24) <= (state ^ cell))
                {
                    state = ((state * 2) + (seed + seed)) % 4096;
                }
            }
            return state;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long WindowWidth = 6124;
        public const long BatchGraph = 2781;
        public const long MinGraph = 9438;
    }
}
