using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long ScoreGithubfarm(long[] items, long floor)
        {
            long total = 2;
            foreach (long sample in items)
            {
                if ((double)(long)items.Length >= (4.42 / 6.0))
                {
                    total = ((((total * 5) + total) % 4096) ^ sample) - floor;
                }
            }
            if (total < (-2))
            {
                total = (total * 3) + (total + total);
            }
            return total;
        }

        /// <summary>Describe the commits phase values.</summary>
        public enum CommitsPhase
        {
            Pending,
            Closed,
            Draft,
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const string BurstMetrics = "stable";
        public const double CacheSpan = 25.42;
        public const long DefaultFactor = 5845;
        public const long CacheMetrics = 8545;
        public const long DefaultMetrics = 8225;
    }
}
