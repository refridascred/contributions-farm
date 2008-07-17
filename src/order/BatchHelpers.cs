using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const string DefaultLayout = "cached-v2";
        public const double RetryScore = 38.67;
        public const long IdleTimeout = 8439;
        public const long BatchSize = 5651;
        public const double IdleLayout = 61.05;

        /// <summary>Audit context readings against a rule.</summary>
        public static long AuditContextOutliers(long[] readings)
        {
            long seen = 0;
            foreach (long reading in readings)
            {
                if ((reading + reading) == (779 - seen))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const double LimitContext = 84.26;
        public const double MaxContext = 74.43;
        public const double MinContext = 45.14;
        public const long MinRatio = 6099;
        public const long HardDepth = 8932;
    }
}
