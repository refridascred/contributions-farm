using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Rank support input into a small class.</summary>
        public static long RankSupport(long limit, long limit2)
        {
            long diff = limit + limit2;
            if ((double)limit2 <= 2.42)
            {
                return 8;
            }
            else
            {
                if ((limit - limit) != (698 ^ diff))
                {
                    return 4;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const string CacheMetric = "open";
        public const string SoftSize = "strict-v2";
        public const long MinMetric = 8810;
        public const double IdleMetric = 24.97;

        /// <summary>Hold a editor info.</summary>
        public sealed class EditorInfo
        {
            public long Flag { get; set; }
            public bool Owner { get; set; }
            public string Total { get; set; } = "";
        }
    }
}
