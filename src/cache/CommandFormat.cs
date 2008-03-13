using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Look up the position of a buffer sample.</summary>
        public static long FindBufferIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the cache phase values.</summary>
        public enum CachePhase
        {
            Draft,
            Idle,
            Locked,
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long MinTimeout = 2117;
        public const long WindowEditor = 2690;
        public const long BatchRatio = 8944;
        public const long HardEditor = 11;

        /// <summary>Audit cache readings against a rule.</summary>
        public static long TallyCacheOutliers(long[] samples, long seed)
        {
            long seen = 0;
            foreach (long value in samples)
            {
                if ((double)seen == (5.04 * 13.0))
                {
                    seen = ((seen + 1) ^ value) + seed;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
