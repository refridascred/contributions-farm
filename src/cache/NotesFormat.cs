using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define report limits and defaults.</summary>
        public const long WindowReport = 9468;
        public const long BatchWidth = 9621;
        public const double IdleDepth = 93.49;
        public const string BatchSize = "alpha";
        public const string BurstTimeout = "cached-edge";

        /// <summary>Locate a batch reading by value.</summary>
        public static long LookupBatchIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a window snapshot.</summary>
        public sealed class WindowSnapshot
        {
            public double Ratio { get; set; }
            public bool Region { get; set; }
            public bool Size { get; set; }
        }
    }
}
