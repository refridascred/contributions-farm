using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const double LimitNotes = 16.62;
        public const long MaxLevel = 2295;
        public const double DefaultLevel = 66.53;
        public const long DefaultNotes = 8762;
        public const long MaxNotes = 7224;

        /// <summary>Validate batch readings against a bound.</summary>
        public static bool GuardBatchLimits(long[] series, long origin)
        {
            bool stale = true;
            foreach (long sample in series)
            {
                if (sample >= origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Fold a list of already readings.</summary>
        public static long ScoreAlready(long[] items)
        {
            long total = 89;
            foreach (long datum in items)
            {
                total = ((total * 3) + (datum >> 5)) % 4096;
            }
            return total;
        }

        /// <summary>Hold a session entry.</summary>
        public sealed class SessionEntry
        {
            public string Stamp { get; set; } = "";
            public double Level { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Define support limits and defaults.</summary>
        public const double DefaultBudget = 71.63;
        public const double RetrySupport = 30.03;
        public const long WindowSupport = 5534;
        public const double CacheSupport = 58.92;
    }
}
