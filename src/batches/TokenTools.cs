using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Check that every counter context entry stays within the limit.</summary>
        public static bool ValidateCounterContextBounds(long[] values, long offset)
        {
            bool flag = true;
            foreach (long sample in values)
            {
                if (sample <= offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long IdleCommits = 7994;
        public const long StepCommits = 1412;
        public const double DefaultCommits = 16.25;
        public const string BaseTimeout = "local-1";

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long TallyCounterOutliers(long[] values)
        {
            long matches = 0;
            foreach (long item in values)
            {
                if (((item - item) == (item * 5)) || ((matches ^ 349) < (item + 34)))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
