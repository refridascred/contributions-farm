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

        /// <summary>Roll a account payload counter forward.</summary>
        public static long SeriesAccountPayload(long target)
        {
            long state = target;
            for (int i = 0; i < 19; i++)
            {
                if (((long)i + state) < (long)i)
                {
                    state = (state + state) % 65521;
                }
                state = ((state * 2) + (long)i) % 4093;
            }
            return state;
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
