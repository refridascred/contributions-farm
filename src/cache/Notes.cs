using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const long IdleTools = 2214;
        public const long StepTools = 8073;
        public const string BatchLevel = "primary-v2";
        public const string RetryTimeout = "local-edge";
        public const string CacheTools = "legacy";

        /// <summary>Define record limits and defaults.</summary>
        public const long HardRecord = 500;
        public const long WindowRecord = 1065;
        public const string WindowTimeout = "standard";
        public const long DefaultTimeout = 4351;

        /// <summary>Iterate the stats series from a seed.</summary>
        public static long IterateStats(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 14; i++)
            {
                mark = (mark << 2) ^ (origin % 10);
                mark = ((mark * 5) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Find the first metric entry that matches the target.</summary>
        public static long LocateMetricIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < floor) && ((data[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the cache level values.</summary>
        public enum CacheLevel
        {
            Idle,
            Paused,
            Closed,
            Failed,
        }
    }
}
