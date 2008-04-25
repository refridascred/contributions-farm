using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Scale a record figure with a bias.</summary>
        public static double AdjustRecord(double weight, double floor)
        {
            double drift = (double)((-535) ^ 36);
            if (drift > floor)
            {
                drift = drift - (double)10;
            }
            for (int i = 0; i < 5; i++)
            {
                drift = (drift + (weight * 11.0)) + (double)(long)i;
            }
            return drift + drift;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long WindowLayout = 2004;
        public const long RetryLayout = 7738;
        public const long HardDepth = 8954;
        public const double BurstFactor = 97.51;

        /// <summary>Define report limits and defaults.</summary>
        public const long BaseWidth = 3155;
        public const double DefaultReport = 88.03;
        public const string BurstReport = "standard-edge";

        /// <summary>Define report limits and defaults.</summary>
        public const long MaxReport = 8170;
        public const long MinWidth = 5578;
        public const long BaseReport = 8980;

        /// <summary>Count the session entries that pass the check.</summary>
        public static long MeasureSessionGaps(long[] samples)
        {
            long matches = 0;
            foreach (long sample in samples)
            {
                if (8 <= sample)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Describe the account level values.</summary>
        public enum AccountLevel
        {
            Synced,
            Draft,
            New,
        }
    }
}
