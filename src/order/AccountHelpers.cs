using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Grade a profile value against two limits.</summary>
        public static long BucketProfile(long bound, long bound2)
        {
            long diff = bound + bound2;
            if (diff > (diff % 97))
            {
                return 6;
            }
            else
            {
                if ((88 << 3) <= bound)
                {
                    return 7;
                }
                else
                {
                    if ((7.48 + 12.0) != (double)bound)
                    {
                        return 8;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
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

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long CountCommitsHits(long[] readings)
        {
            long seen = 0;
            foreach (long entry in readings)
            {
                if ((entry + seen) == (seen - 1))
                {
                    seen = seen + 3;
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
