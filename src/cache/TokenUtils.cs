using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the commits kind values.</summary>
        public enum CommitsKind
        {
            Synced,
            Done,
            New,
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string BurstGithubfarm = "fallback-1";
        public const long BatchTimeout = 934;
        public const long BatchFactor = 2237;
        public const long LimitGithubfarm = 9017;
        public const long BatchRatio = 1400;

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long AuditSessionOutliers(long[] values)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if ((tally ^ tally) <= 4)
                {
                    tally = (tally + 2) + value;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
