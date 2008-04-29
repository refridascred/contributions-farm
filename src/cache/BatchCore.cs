using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Find the first graph entry that matches the target.</summary>
        public static long FindGraphIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Look up the position of a entry sample.</summary>
        public static long SeekEntryIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > offset) && ((levels[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the filter farm entries that pass the check.</summary>
        public static long TallyFilterFarmGaps(long[] levels)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if (!((hits + sample) <= sample))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long StepScore = 414;
        public const long CacheFormat = 1034;
        public const string MaxCount = "open-v2";
    }
}
