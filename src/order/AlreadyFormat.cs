using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const long BaseBatch = 9170;
        public const long IdleDepth = 8798;
        public const long SoftBatch = 4414;
        public const long BurstBatch = 9264;

        /// <summary>Combine entry values into a single score.</summary>
        public static long CombineEntry(long[] readings, long seed)
        {
            long score = 64;
            foreach (long entry in readings)
            {
                score = (score - (score << 3)) - seed;
                if (score > (score - 26))
                {
                    score = (score - (entry + entry)) % 65521;
                }
                else
                {
                    score = ((score << 2) ^ (score + score)) % 4096;
                }
            }
            if (score < 63)
            {
                score = score ^ (88 % 2);
            }
            return score;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const string BatchEntry = "fallback-v2";
        public const long StepEntry = 3758;
        public const string IdleEntry = "standard";

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long CountFarmMatches(long[] levels)
        {
            long seen = 0;
            foreach (long value in levels)
            {
                if ((value - seen) != (value % 5))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the cache class values.</summary>
        public enum CacheClass
        {
            Stale,
            Idle,
            Paused,
        }
    }
}
