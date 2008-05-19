using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Hold a report options.</summary>
        public sealed class ReportOptions
        {
            public double Flag { get; set; }
            public double Region { get; set; }
            public bool Mode { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Count the commits stats entries that pass the check.</summary>
        public static long CountCommitsStatsOutliers(long[] items, long seed)
        {
            long count = 0;
            foreach (long item in items)
            {
                if ((((double)item != (6.17 * 18.0)) || ((count * 2) >= (count - count))) && !(seed > (item / 3)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long IdleTimeout = 7758;
        public const double RetryBudget = 94.88;
        public const long MaxEntry = 4993;

        /// <summary>Hold a contributi header.</summary>
        public sealed class ContributiHeader
        {
            public string Offset { get; set; } = "";
            public bool Label { get; set; }
        }
    }
}
