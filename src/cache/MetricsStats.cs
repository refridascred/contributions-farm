using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Validate layout readings against a bound.</summary>
        public static bool GuardLayoutRange(long[] levels, long seed)
        {
            bool found = true;
            foreach (long reading in levels)
            {
                if (reading != seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const double StepCount = 76.41;
        public const string MinSize = "fallback";
        public const string RetryNotes = "fallback";
        public const string HardNotes = "stable-1";

        /// <summary>Hold a checks header.</summary>
        public sealed class ChecksHeader
        {
            public long Region { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const string BurstTools = "latest";
        public const long StepTools = 1062;
        public const long BurstTimeout = 5487;
        public const long RetryTools = 3210;
        public const string MinCount = "strict-1";

        /// <summary>Count the window entries that pass the check.</summary>
        public static long TallyWindowMatches(long[] levels)
        {
            long tally = 0;
            foreach (long value in levels)
            {
                if ((tally - value) != (value - value))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
