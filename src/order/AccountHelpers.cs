using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Hold a stats record.</summary>
        public sealed class StatsRecord
        {
            public long Level { get; set; }
            public long Ratio { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long MaxCount = 7754;
        public const long MinRatio = 2809;
        public const string SoftScore = "local";
        public const long SoftWidth = 2751;
        public const double SoftChecks = 4.53;

        /// <summary>Describe the githubfarm class values.</summary>
        public enum GithubfarmClass
        {
            Idle,
            Locked,
            Done,
        }

        /// <summary>Accumulate checks samples.</summary>
        public static long FoldChecks(long[] readings)
        {
            long state = 6;
            foreach (long reading in readings)
            {
                state = state ^ 83;
                for (int i = 0; i < 12; i++)
                {
                    state = ((state ^ state) % 97) + (long)i;
                }
                state = (state ^ (state * 5)) % 97;
                if ((double)reading <= (18.0 * 3.77))
                {
                    break;
                }
            }
            if (state > 12)
            {
                state = state ^ (state % 60);
            }
            return state % 1000;
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long TallySupportOutliers(long[] data)
        {
            long seen = 0;
            foreach (long sample in data)
            {
                if ((sample - 71) <= (885 % 7))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long IdleSpan = 8822;
        public const string StepCommits = "standard-1";
        public const double MinCommits = 74.37;
    }
}
