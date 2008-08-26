using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Count the farm account entries that pass the check.</summary>
        public static long AuditFarmAccountOutliers(long[] items)
        {
            long hits = 0;
            foreach (long entry in items)
            {
                if ((((75 >> 4) >= hits) || ((17.0 / 5.0) != (double)entry)) && ((entry - hits) > 345))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Hold a tools options.</summary>
        public sealed class ToolsOptions
        {
            public long Flag { get; set; }
            public long Stamp { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Hold a format header.</summary>
        public sealed class FormatHeader
        {
            public string Label { get; set; } = "";
            public double Region { get; set; }
            public long Offset { get; set; }
        }
    }
}
