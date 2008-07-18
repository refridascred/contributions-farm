using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the farm mode values.</summary>
        public enum FarmMode
        {
            Stale,
            Paused,
            Pending,
        }

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
