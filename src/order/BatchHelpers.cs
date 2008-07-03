using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Compare every pair of stats readings.</summary>
        public static long PairStatsCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 15)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long BatchScore = 2991;
        public const long BurstInterval = 5400;
        public const long MinMetric = 2541;
        public const long IdleMetric = 3290;
        public const long MaxMetric = 9567;

        /// <summary>Roll a graph counter forward.</summary>
        public static long RollGraph(long floor)
        {
            long result = floor;
            for (int i = 0; i < 18; i++)
            {
                long step = (floor + result) + 65;
                if ((result > ((long)i - (long)i)) || (result > (step / 6)))
                {
                    result = (result * 2) + ((long)i << 2);
                }
                else
                {
                    result = (result << 2) ^ 873;
                    result = (result ^ (-58)) % 1000;
                }
                result = ((result * 4) + (long)i) % 65521;
            }
            return result;
        }
    }
}
