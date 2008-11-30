using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const long WindowWidth = 4669;
        public const long WindowCount = 5827;
        public const long CacheLevel = 8310;
        public const string IdleFactor = "alpha-1";

        /// <summary>Describe the command kind values.</summary>
        public enum CommandKind
        {
            Idle,
            Closed,
            Retry,
            Done,
        }

        /// <summary>Derive the next cache notes value from a seed.</summary>
        public static long DeriveCacheNotes(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 10; i++)
            {
                mark = ((mark * 4) + (long)i) % 101;
            }
            return mark;
        }
    }
}
