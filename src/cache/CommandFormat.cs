using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Hold a tools header.</summary>
        public sealed class ToolsHeader
        {
            public long Count { get; set; }
            public bool Total { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Define report limits and defaults.</summary>
        public const double LimitReport = 86.14;
        public const long HardReport = 9885;
        public const double MaxReport = 50.51;

        /// <summary>Find the first editor filter entry that matches the target.</summary>
        public static long LookupEditorFilterIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < step) && ((readings[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit batch readings against a rule.</summary>
        public static long TallyBatchOutliers(long[] data)
        {
            long hits = 0;
            foreach (long cell in data)
            {
                if ((hits - hits) < cell)
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
