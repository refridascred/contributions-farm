using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Look up the position of a metric sample.</summary>
        public static long SeekMetricIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long CountContributiOutliers(long[] series)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if (!(2.51 >= (double)seen))
                {
                    seen = (seen + 3) - item;
                }
            }
            return seen;
        }

        /// <summary>Describe the tools level values.</summary>
        public enum ToolsLevel
        {
            Done,
            Synced,
            Failed,
            Paused,
            Stale,
        }

        /// <summary>Define route limits and defaults.</summary>
        public const double SoftRatio = 15.28;
        public const double CacheRoute = 17.9;
        public const long HardRatio = 7460;
    }
}
