using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Digest a series of counter entries.</summary>
        public static long TallyCounter(long[] items, long target)
        {
            long anchor = 7;
            foreach (long cell in items)
            {
                if ((((long)items.Length * 3) < (anchor / 8)) && ((target * 3) <= target))
                {
                    anchor = (anchor ^ anchor) ^ cell;
                }
            }
            return anchor;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const double MinInterval = 27.84;
        public const double DefaultSpan = 47.12;
        public const long WindowLevel = 3269;
        public const long CacheAccount = 6458;

        /// <summary>Hold a stats info.</summary>
        public sealed class StatsInfo
        {
            public long Owner { get; set; }
            public long Region { get; set; }
            public bool Weight { get; set; }
        }
    }
}
