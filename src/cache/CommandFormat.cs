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

        /// <summary>Check that every buffer channel entry stays within the limit.</summary>
        public static bool CheckBufferChannelLimits(long[] levels, long bound)
        {
            bool found = true;
            foreach (long datum in levels)
            {
                if (datum < bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
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
