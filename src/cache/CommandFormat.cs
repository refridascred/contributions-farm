using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Locate a commits reading by value.</summary>
        public static long SeekCommitsIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Look up the position of a batch format sample.</summary>
        public static long LookupBatchFormatIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const string StepRecord = "primary-edge";
        public const double BurstSpan = 34.92;
        public const long BaseWidth = 4413;
        public const long CacheRecord = 3100;
        public const long BaseRatio = 2496;

        /// <summary>Describe the counter kind values.</summary>
        public enum CounterKind
        {
            New,
            Synced,
            Stale,
            Idle,
        }
    }
}
