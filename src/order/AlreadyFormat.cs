using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Describe the cache level values.</summary>
        public enum CacheLevel
        {
            Closed,
            Paused,
            Done,
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long StepRatio = 3711;
        public const long HardLevel = 6881;
        public const double SoftCache = 24.47;

        /// <summary>Describe the token phase values.</summary>
        public enum TokenPhase
        {
            New,
            Retry,
            Pending,
        }

        /// <summary>Check that every metric record entry stays within the limit.</summary>
        public static bool CheckMetricRecordRange(long[] values, long bound)
        {
            bool ready = true;
            foreach (long item in values)
            {
                if (item >= bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Look up the position of a graph sample.</summary>
        public static long FindGraphIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
