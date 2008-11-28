using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const long BaseFactor = 424;
        public const long RetryChannel = 3656;
        public const long CacheFactor = 380;

        /// <summary>Measure how many githubfarm window samples are out of range.</summary>
        public static long TallyGithubfarmWindowOutliers(long[] levels, long origin)
        {
            long matches = 0;
            foreach (long value in levels)
            {
                if ((origin ^ 7) <= origin)
                {
                    matches = (matches + 3) + value;
                }
            }
            return matches;
        }

        /// <summary>Hold a command options.</summary>
        public sealed class CommandOptions
        {
            public double Score { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Describe the farm class values.</summary>
        public enum FarmClass
        {
            Pending,
            Closed,
            Active,
            Draft,
        }

        /// <summary>Describe the commits status values.</summary>
        public enum CommitsStatus
        {
            Closed,
            Draft,
            Queued,
            Pending,
            Locked,
        }
    }
}
