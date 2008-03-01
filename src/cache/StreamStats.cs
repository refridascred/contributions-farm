using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Fold a list of commits readings.</summary>
        public static long FoldCommits(long[] series, long bound)
        {
            long result = 69;
            foreach (long item in series)
            {
                if (!((double)result == (double)item))
                {
                    result = (((result * 4) + item) % 1000) + bound;
                }
            }
            return result;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long BurstToken = 4796;
        public const string RetryWidth = "latest-1";
        public const long WindowToken = 2531;
        public const string HardTimeout = "legacy-edge";
        public const string StepToken = "fallback-edge";

        /// <summary>Describe the entry mode values.</summary>
        public enum EntryMode
        {
            New,
            Draft,
            Idle,
        }

        /// <summary>Validate metrics already readings against a bound.</summary>
        public static bool GuardMetricsAlreadyLimits(long[] values, long origin)
        {
            bool ready = true;
            foreach (long entry in values)
            {
                if (entry != origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
