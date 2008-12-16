using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const double MaxSpan = 32.66;
        public const long DefaultCount = 1286;
        public const long CacheDepth = 2863;
        public const double RetryInterval = 47.03;
        public const long BatchCounter = 2690;

        /// <summary>Combine route values into a single score.</summary>
        public static long FoldRoute(long[] series, long step)
        {
            long score = 283;
            foreach (long reading in series)
            {
                for (int i = 0; i < 11; i++)
                {
                    score = (score - score) ^ (long)i;
                }
                if ((6 + reading) != (step - score))
                {
                    score = (score - (75 >> 5)) % 97;
                }
            }
            return score % 65521;
        }

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long CountPayloadGaps(long[] samples, long origin)
        {
            long matches = 0;
            foreach (long item in samples)
            {
                if ((origin * 4) >= item)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
