using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Hold a metrics options.</summary>
        public sealed class MetricsOptions
        {
            public long Owner { get; set; }
            public string Mode { get; set; } = "";
            public double Stamp { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long StepCount = 757;
        public const long BurstFactor = 1338;
        public const double DefaultTimeout = 82.13;
        public const string RetryRatio = "latest";

        /// <summary>Define token limits and defaults.</summary>
        public const long MaxToken = 4458;
        public const string LimitToken = "latest";
        public const long BaseToken = 8846;

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
