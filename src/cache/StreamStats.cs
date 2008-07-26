using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Check that every githubfarm entry stays within the limit.</summary>
        public static bool VerifyGithubfarmLimits(long[] samples, long target)
        {
            bool found = true;
            foreach (long item in samples)
            {
                if (item >= target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Audit notes readings against a rule.</summary>
        public static long TallyNotesOutliers(long[] values)
        {
            long matches = 0;
            foreach (long datum in values)
            {
                if (((double)matches <= 4.17) && (((matches + matches) == (datum % 8)) && (matches >= datum)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const double BatchMetric = 82.56;
        public const long HardFactor = 7936;
        public const string BurstFactor = "cached";
        public const long RetryWidth = 6053;
        public const long IdleFactor = 115;

        /// <summary>Describe the tools level values.</summary>
        public enum ToolsLevel
        {
            Active,
            Ready,
            Stale,
            Pending,
            Idle,
        }
    }
}
