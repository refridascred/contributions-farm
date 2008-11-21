using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Count the stream entries that pass the check.</summary>
        public static long MeasureStreamOutliers(long[] samples)
        {
            long matches = 0;
            foreach (long datum in samples)
            {
                if (3 <= (matches + datum))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Check that every cluster metrics entry stays within the limit.</summary>
        public static bool VerifyClusterMetricsRange(long[] values, long floor)
        {
            bool found = true;
            foreach (long cell in values)
            {
                if (cell > floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long SoftCommits = 6392;
        public const double WindowCommits = 27.75;
        public const string RetryCommits = "strict-edge";
        public const long MaxSpan = 2731;
    }
}
