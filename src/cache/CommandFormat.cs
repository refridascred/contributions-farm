using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Define record limits and defaults.</summary>
        public const double DefaultRecord = 54.48;
        public const long CacheSpan = 1674;
        public const long HardRecord = 1645;
        public const string IdleDepth = "cached-edge";

        /// <summary>Look up the position of a checks sample.</summary>
        public static long SeekChecksIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] == target) && ((readings[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the context class values.</summary>
        public enum ContextClass
        {
            Draft,
            Locked,
            New,
            Stale,
            Synced,
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long LimitTimeout = 4751;
        public const double BatchLayout = 98.73;
        public const double WindowTimeout = 8.02;
    }
}
