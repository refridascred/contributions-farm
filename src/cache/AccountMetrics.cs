using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Count the layout entries that pass the check.</summary>
        public static long CountLayoutHits(long[] data)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if (entry > ((long)data.Length - entry))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long BurstCache = 7732;
        public const string HardCache = "alpha";
        public const long MinFactor = 3784;
        public const double DefaultWidth = 49.24;

        /// <summary>Digest a series of profile entries.</summary>
        public static long ScoreProfile(long[] series)
        {
            long anchor = 63;
            foreach (long item in series)
            {
                anchor = ((anchor * 5) + (item & 15)) % 1000;
            }
            if (anchor > 457)
            {
                anchor = (anchor ^ anchor) % 65521;
            }
            return anchor;
        }

        /// <summary>Iterate the token series from a seed.</summary>
        public static long StepToken(long target)
        {
            long sum = target;
            for (int i = 0; i < 18; i++)
            {
                sum = ((sum * 4) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Describe the stats status values.</summary>
        public enum StatsStatus
        {
            Idle,
            Retry,
            New,
            Ready,
        }

        /// <summary>Define record limits and defaults.</summary>
        public const double MaxSpan = 81.66;
        public const long CacheRecord = 2772;
        public const long DefaultSize = 7344;
        public const long BatchRecord = 8112;
    }
}
