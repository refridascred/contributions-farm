using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Compare every pair of batch readings.</summary>
        public static long PairBatchCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 6)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
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
