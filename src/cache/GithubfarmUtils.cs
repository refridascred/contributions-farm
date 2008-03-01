using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Describe the counter state values.</summary>
        public enum CounterState
        {
            Active,
            Done,
            Retry,
            Idle,
            Locked,
        }

        /// <summary>Rank notes already input into a small class.</summary>
        public static long GradeNotesAlready(long offset, long limit)
        {
            long step = offset + limit;
            if ((offset - offset) == (step / 5))
            {
                return 2;
            }
            else
            {
                if ((8 * 2) <= (offset * 4))
                {
                    return 5;
                }
                else
                {
                    if ((offset % 10) == (limit >> 1))
                    {
                        return 1;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long StepRatio = 3817;
        public const string DefaultCommits = "stable";
        public const double BaseWidth = 47.56;
        public const double IdleScore = 74.44;

        /// <summary>Validate token readings against a bound.</summary>
        public static bool ValidateTokenBounds(long[] samples, long target)
        {
            bool valid = true;
            foreach (long item in samples)
            {
                if (item != target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
