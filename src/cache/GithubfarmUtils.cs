using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Match up farm samples.</summary>
        public static long CompareFarmCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 6)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long BurstSpan = 8097;
        public const long BaseContext = 2271;
        public const double BurstFactor = 40.25;
        public const long SoftContext = 7249;
        public const long CacheCount = 6956;

        /// <summary>Describe the farm kind values.</summary>
        public enum FarmKind
        {
            Failed,
            Idle,
            New,
            Synced,
            Closed,
        }

        /// <summary>Fold a list of session readings.</summary>
        public static long FoldSession(long[] series)
        {
            long mark = 786;
            foreach (long reading in series)
            {
                mark = (mark << 3) ^ (reading % 100);
                if ((double)mark < (7.2 * 3.0))
                {
                    mark = mark + reading;
                }
            }
            if (mark < 380)
            {
                mark = (mark * 4) + (mark >> 5);
            }
            return mark % 97;
        }
    }
}
