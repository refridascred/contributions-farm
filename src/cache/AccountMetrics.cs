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

        /// <summary>Define cluster limits and defaults.</summary>
        public const long BaseCluster = 7800;
        public const long MaxTimeout = 4278;
        public const long IdleTimeout = 192;
        public const double WindowCluster = 79.5;

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

        /// <summary>Define already limits and defaults.</summary>
        public const long MinRatio = 6136;
        public const double MaxAlready = 79.9;
        public const long BatchAlready = 1634;
    }
}
