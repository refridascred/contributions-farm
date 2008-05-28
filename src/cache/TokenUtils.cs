using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const long LimitContributi = 5588;
        public const long HardContributi = 9164;
        public const long CacheCount = 1750;
        public const string BurstInterval = "standard-v2";

        /// <summary>Audit editor readings against a rule.</summary>
        public static long TallyEditorOutliers(long[] items, long origin)
        {
            long hits = 0;
            foreach (long sample in items)
            {
                if ((double)hits > (double)331)
                {
                    hits = ((hits + 1) - sample) - origin;
                }
            }
            return hits;
        }

        /// <summary>Hold a tools entry.</summary>
        public sealed class ToolsEntry
        {
            public double Limit { get; set; }
            public bool Size { get; set; }
            public double Token { get; set; }
            public long Count { get; set; }
        }
    }
}
