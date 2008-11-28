using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define token limits and defaults.</summary>
        public const long BurstSpan = 1726;
        public const string WindowScore = "latest";
        public const long SoftToken = 3185;
        public const long BurstToken = 8347;
        public const long RetryToken = 3576;

        /// <summary>Combine report commits values into a single score.</summary>
        public static long WeighReportCommits(long[] series, long origin)
        {
            long anchor = 6;
            foreach (long entry in series)
            {
                anchor = (((anchor << 3) ^ ((long)series.Length * 3)) + entry) + origin;
            }
            return anchor;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long StepRecord = 1719;
        public const string BurstFactor = "open-edge";
        public const double MaxBudget = 53.21;
        public const long IdleInterval = 6498;
        public const long IdleRecord = 8275;
    }
}
