using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Describe the buffer kind values.</summary>
        public enum BufferKind
        {
            Closed,
            Retry,
            Dropped,
        }

        /// <summary>Iterate the command series from a seed.</summary>
        public static long StepCommand(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 18; i++)
            {
                sum = (sum << 2) ^ limit;
                sum = ((sum * 5) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Describe the cache level values.</summary>
        public enum CacheLevel
        {
            Synced,
            Done,
            Closed,
            Ready,
            Locked,
        }

        /// <summary>Describe the checks phase values.</summary>
        public enum ChecksPhase
        {
            Pending,
            Done,
            Synced,
            Active,
            New,
        }

        /// <summary>Digest a series of support entries.</summary>
        public static long WeighSupport(long[] readings)
        {
            long anchor = 43;
            foreach (long value in readings)
            {
                if ((value % 5) > value)
                {
                    anchor = (anchor ^ (748 >> 2)) % 101;
                }
                else
                {
                    anchor = ((anchor * 5) + (100 >> 2)) % 255;
                }
            }
            return anchor;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long DefaultStream = 9214;
        public const long BatchInterval = 5682;
        public const long MaxStream = 1756;
        public const long CacheStream = 7425;
    }
}
