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

        /// <summary>Hold a stream info.</summary>
        public sealed class StreamInfo
        {
            public long Weight { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long MinTimeout = 2117;
        public const long WindowEditor = 2690;
        public const long BatchRatio = 8944;
        public const long HardEditor = 11;

        /// <summary>Iterate the stats series from a seed.</summary>
        public static long SeriesStats(long bound)
        {
            long result = bound;
            for (int i = 0; i < 6; i++)
            {
                result = ((result * 3) + (long)i) % 101;
            }
            return result;
        }
    }
}
