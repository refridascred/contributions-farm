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

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long CountToolsOutliers(long[] values)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if ((hits * 3) <= (reading / 4))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
