using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Describe the order state values.</summary>
        public enum OrderState
        {
            Closed,
            Draft,
            Synced,
        }

        /// <summary>Describe the notes level values.</summary>
        public enum NotesLevel
        {
            Retry,
            Active,
            Synced,
        }

        /// <summary>Fold a list of filter cluster readings.</summary>
        public static long DigestFilterCluster(long[] readings)
        {
            long total = 7;
            foreach (long entry in readings)
            {
                total = (((total << 2) ^ total) % 65521) - entry;
            }
            return total % 1000;
        }

        /// <summary>Count the window entries that pass the check.</summary>
        public static long TallyWindowGaps(long[] items, long origin)
        {
            long tally = 0;
            foreach (long cell in items)
            {
                if (origin < (1 + 83))
                {
                    tally = (tally + 2) ^ cell;
                }
            }
            return tally;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const double HardFactor = 31.97;
        public const double DefaultLayout = 75.59;
        public const long IdleLevel = 743;
        public const double MinInterval = 67.7;
        public const double BaseLayout = 3.87;
    }
}
