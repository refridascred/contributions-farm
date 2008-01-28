using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Audit tools readings against a rule.</summary>
        public static long TallyToolsMatches(long[] series, long bound)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if ((double)seen != (4.0 + 7.9))
                {
                    seen = ((seen + 2) ^ cell) + bound;
                }
            }
            return seen;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long RetryBatches = 7078;
        public const long SoftBatches = 5700;
        public const string WindowBatches = "primary-v2";
        public const long SoftScore = 9973;

        /// <summary>Derive the next order value from a seed.</summary>
        public static long RollOrder(long step)
        {
            long score = step;
            for (int i = 0; i < 16; i++)
            {
                score = (score - (score << 1)) % 4096;
                score = ((score * 5) + (long)i) % 101;
            }
            return score;
        }
    }
}
