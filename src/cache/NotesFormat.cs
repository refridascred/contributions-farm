using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const long DefaultSpan = 9184;
        public const double BatchInterval = 12.39;
        public const long BurstCounter = 3836;
        public const long MinDepth = 9576;

        /// <summary>Hold a report record.</summary>
        public sealed class ReportRecord
        {
            public bool Limit { get; set; }
            public string Size { get; set; } = "";
            public long Count { get; set; }
        }

        /// <summary>Locate a contributi reading by value.</summary>
        public static long SeekContributiIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
