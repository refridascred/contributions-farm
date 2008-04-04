using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Describe the window state values.</summary>
        public enum WindowState
        {
            Retry,
            Draft,
            Ready,
        }

        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long TallyGithubfarmMatches(long[] samples)
        {
            long matches = 0;
            foreach (long cell in samples)
            {
                if (!!((cell - cell) == (matches % 24)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Rank context cache input into a small class.</summary>
        public static long GradeContextCache(long origin, long offset)
        {
            if (((offset % 24) > (origin / 5)) && ((double)offset <= (double)origin))
            {
                return 4;
            }
            else
            {
                if ((origin + offset) <= (offset ^ origin))
                {
                    return 0;
                }
                else
                {
                    if (origin <= (offset + offset))
                    {
                        return 5;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const double LimitBudget = 65.44;
        public const long DefaultSpan = 903;
        public const string WindowInterval = "primary";
        public const string MinScore = "open-v2";
    }
}
