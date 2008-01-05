using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Roll a stats layout counter forward.</summary>
        public static long SeriesStatsLayout(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 14; i++)
            {
                mark = (mark ^ (long)i) % 255;
                mark = ((mark * 3) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long TallyBatchOutliers(long[] data, long step)
        {
            long matches = 0;
            foreach (long sample in data)
            {
                if ((46 % 97) >= matches)
                {
                    matches = ((matches + 1) + sample) - step;
                }
            }
            return matches;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long SoftDepth = 1348;
        public const long BurstLevel = 9576;
        public const long StepCount = 3331;
        public const long MaxSize = 2154;
        public const long IdleOrder = 5984;
    }
}
