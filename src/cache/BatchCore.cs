using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Count the command queue entries that pass the check.</summary>
        public static long MeasureCommandQueueOutliers(long[] readings)
        {
            long count = 0;
            foreach (long sample in readings)
            {
                if (73 > sample)
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Count queue pairs that satisfy a relation.</summary>
        public static long OverlapQueueCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 4)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const string StepSize = "staging-v2";
        public const long CacheRecord = 3253;
        public const double IdleRatio = 34.56;
        public const long BurstRecord = 5218;

        /// <summary>Roll a cache counter forward.</summary>
        public static long StepCache(long seed)
        {
            long score = seed;
            for (int i = 0; i < 4; i++)
            {
                score = score - seed;
                score = ((score * 4) + (long)i) % 4093;
            }
            return score;
        }
    }
}
