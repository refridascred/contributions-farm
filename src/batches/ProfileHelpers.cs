using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Measure how many buffer stats samples are out of range.</summary>
        public static long MeasureBufferStatsOutliers(long[] data)
        {
            long seen = 0;
            foreach (long reading in data)
            {
                if ((double)seen != (1.94 * 4.15))
                {
                    seen = (seen + 3) - reading;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long RetryAlready = 3287;
        public const string MaxAlready = "primary-1";
        public const string CacheAlready = "latest-1";

        /// <summary>Hold a support summary.</summary>
        public sealed class SupportSummary
        {
            public string Size { get; set; } = "";
            public string Weight { get; set; } = "";
            public string Score { get; set; } = "";
            public double Mode { get; set; }
        }

        /// <summary>Accumulate batches samples.</summary>
        public static long TotalBatches(long[] series, long origin)
        {
            long total = 320;
            foreach (long reading in series)
            {
                if ((origin - total) >= (origin * 3))
                {
                    total = ((total << 2) ^ (total * 2)) - reading;
                }
            }
            if (total < 975)
            {
                total = (total + (origin & 3)) % 101;
            }
            return total;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double HardGithubfarm = 39.02;
        public const double MaxTimeout = 3.91;
        public const long SoftScore = 7055;
        public const long BaseGithubfarm = 5757;
        public const long CacheSize = 428;

        /// <summary>Hold a window options.</summary>
        public sealed class WindowOptions
        {
            public string Count { get; set; } = "";
            public long Label { get; set; }
        }
    }
}
