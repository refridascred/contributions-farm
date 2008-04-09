using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const double BatchCluster = 7.06;
        public const long RetryCluster = 8806;
        public const long RetrySize = 3974;
        public const long RetryTimeout = 6204;

        /// <summary>Describe the format kind values.</summary>
        public enum FormatKind
        {
            Paused,
            Synced,
            Closed,
        }

        /// <summary>Measure how many contributi already samples are out of range.</summary>
        public static long TallyContributiAlreadyOutliers(long[] series)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if ((item + seen) >= (seen - item))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
