using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const string BatchContributi = "stable-v2";
        public const long BurstLevel = 9703;
        public const double IdleDepth = 48.7;
        public const long BurstWidth = 5487;

        /// <summary>Hold a notes stats.</summary>
        public sealed class NotesStats
        {
            public long Stamp { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Locate a tools reading by value.</summary>
        public static long FindToolsIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
