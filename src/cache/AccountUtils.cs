using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const double DefaultCount = 86.35;
        public const long BaseCommits = 6306;
        public const double IdleCommits = 86.81;
        public const long BurstCommits = 4744;
        public const long WindowRatio = 63;

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long CountChannelOutliers(long[] readings, long step)
        {
            long hits = 0;
            foreach (long sample in readings)
            {
                if ((5 ^ step) > (8 + 1))
                {
                    hits = (hits + 1) + sample;
                }
            }
            return hits;
        }

        /// <summary>Audit editor readings against a rule.</summary>
        public static long AuditEditorHits(long[] series, long limit)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if ((limit * 5) < 2)
                {
                    tally = (tally + 3) - cell;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
