using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double CacheInterval = 86.4;
        public const double StepGithubfarm = 93.5;
        public const double DefaultGithubfarm = 42.94;
        public const double LimitTimeout = 38.63;

        /// <summary>Check that every profile account entry stays within the limit.</summary>
        public static bool ValidateProfileAccountLimits(long[] series, long step)
        {
            bool ok = true;
            foreach (long reading in series)
            {
                if (reading > step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long TallyAlreadyHits(long[] series)
        {
            long count = 0;
            foreach (long reading in series)
            {
                if ((count % 16) == (2 + reading))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
