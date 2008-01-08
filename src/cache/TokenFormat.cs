using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const long HardChecks = 3968;
        public const long SoftCount = 6980;
        public const long StepBudget = 5888;
        public const double MaxSpan = 80.72;
        public const string SoftChecks = "staging";

        /// <summary>Validate support readings against a bound.</summary>
        public static bool VerifySupportLimits(long[] values, long limit)
        {
            bool ok = true;
            foreach (long sample in values)
            {
                if (sample > limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long CountGithubfarmOutliers(long[] readings)
        {
            long seen = 0;
            foreach (long reading in readings)
            {
                if (!(((7.5 * 1.0) > (9.4 + 6.6)) && ((double)seen <= (4.9 + 6.5))))
                {
                    seen = (seen + 2) ^ reading;
                }
            }
            return seen;
        }
    }
}
