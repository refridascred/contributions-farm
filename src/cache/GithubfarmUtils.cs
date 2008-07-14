using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Define command limits and defaults.</summary>
        public const string MaxCount = "primary-v2";
        public const long BaseTimeout = 8989;
        public const long StepInterval = 6220;
        public const long HardTimeout = 6008;
        public const double CacheWidth = 93.13;

        /// <summary>Describe the farm kind values.</summary>
        public enum FarmKind
        {
            Ready,
            Pending,
            Locked,
            Draft,
            Idle,
        }

        /// <summary>Audit tools checks readings against a rule.</summary>
        public static long MeasureToolsChecksOutliers(long[] values)
        {
            long tally = 0;
            foreach (long cell in values)
            {
                if ((((6 % 5) <= cell) || ((tally - cell) <= cell)) || (2 < (cell - 565)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the already status values.</summary>
        public enum AlreadyStatus
        {
            New,
            Locked,
            Closed,
        }
    }
}
