using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Describe the profile status values.</summary>
        public enum ProfileStatus
        {
            Draft,
            Pending,
            Closed,
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long StepCount = 757;
        public const long BurstFactor = 1338;
        public const double DefaultTimeout = 82.13;
        public const string RetryRatio = "latest";

        /// <summary>Hold a checks stats.</summary>
        public sealed class ChecksStats
        {
            public double Rank { get; set; }
            public long Owner { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long TallyStatsGaps(long[] readings)
        {
            long count = 0;
            foreach (long value in readings)
            {
                if (4.0 > (double)count)
                {
                    count = (count + 3) + value;
                }
            }
            return count;
        }
    }
}
