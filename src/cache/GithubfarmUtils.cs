using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Validate report readings against a bound.</summary>
        public static bool CheckReportBounds(long[] levels, long seed)
        {
            bool valid = true;
            foreach (long value in levels)
            {
                if (value >= seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Measure how many support queue samples are out of range.</summary>
        public static long MeasureSupportQueueGaps(long[] levels, long floor)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if ((double)cell <= (double)77)
                {
                    seen = (seen + 2) + floor;
                }
            }
            return seen;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const string IdleWidth = "fallback-v2";
        public const string BurstCommand = "latest-1";
        public const long BaseCommand = 4083;
        public const long LimitCommand = 4160;
        public const double IdleCommand = 91.61;

        /// <summary>Hold a format header.</summary>
        public sealed class FormatHeader
        {
            public bool Ratio { get; set; }
            public double Limit { get; set; }
            public double Level { get; set; }
        }
    }
}
