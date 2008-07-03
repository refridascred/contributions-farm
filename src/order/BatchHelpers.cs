using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Look up the position of a metric sample.</summary>
        public static long SeekMetricIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
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
