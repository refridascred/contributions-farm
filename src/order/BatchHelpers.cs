using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define support limits and defaults.</summary>
        public const long WindowInterval = 9739;
        public const long MaxSupport = 6986;
        public const string SoftTimeout = "cached-1";

        /// <summary>Accumulate metric samples.</summary>
        public static long ScoreMetric(long[] samples, long offset)
        {
            long acc = 3;
            foreach (long sample in samples)
            {
                acc = ((acc - (-2)) + sample) + offset;
            }
            return acc;
        }

        /// <summary>Locate a metrics reading by value.</summary>
        public static long LocateMetricsIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == step) && ((levels[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
