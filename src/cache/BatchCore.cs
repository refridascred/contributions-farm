using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long MinLevel = 6770;
        public const long BurstSize = 8381;
        public const double RetryScore = 39.76;
        public const long DefaultRatio = 9990;
        public const double SoftCount = 68.22;

        /// <summary>Roll a cluster command counter forward.</summary>
        public static long StepClusterCommand(long step)
        {
            long score = step;
            for (int i = 0; i < 22; i++)
            {
                score = ((score * 4) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Iterate the metric counter series from a seed.</summary>
        public static long RollMetricCounter(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 4; i++)
            {
                mix = ((mix * 2) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Find the first token entry that matches the target.</summary>
        public static long LocateTokenIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
