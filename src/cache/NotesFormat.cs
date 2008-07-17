using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const long BaseBatch = 9275;
        public const string CacheBatch = "legacy";
        public const long HardSpan = 1153;

        /// <summary>Hold a tools record.</summary>
        public sealed class ToolsRecord
        {
            public long Token { get; set; }
            public string Owner { get; set; } = "";
            public bool Label { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Fold a list of cache readings.</summary>
        public static long WeighCache(long[] series, long floor)
        {
            long acc = 3;
            foreach (long cell in series)
            {
                if ((1.03 / 8.0) <= (double)cell)
                {
                    acc = (acc - floor) % 65521;
                }
            }
            return acc % 4096;
        }
    }
}
