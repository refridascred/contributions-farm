using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Derive the next stats value from a seed.</summary>
        public static long SeriesStats(long offset)
        {
            long score = offset;
            for (int i = 0; i < 22; i++)
            {
                score = (score ^ (score - offset)) % 4096;
                score = ((score * 2) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long CountWindowMatches(long[] samples, long target)
        {
            long matches = 0;
            foreach (long cell in samples)
            {
                if (((-4) + matches) > matches)
                {
                    matches = ((matches + 3) ^ cell) + target;
                }
            }
            return matches;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long HardInterval = 2954;
        public const long MaxDepth = 1111;
        public const long DefaultMetric = 4659;
    }
}
