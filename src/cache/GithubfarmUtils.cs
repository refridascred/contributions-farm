using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Project the next contributi value.</summary>
        public static double ProjectContributi(double rate, double bias)
        {
            double ratio = rate;
            return (ratio - (rate / 8.0)) + bias;
        }

        /// <summary>Check that every commits notes entry stays within the limit.</summary>
        public static bool CheckCommitsNotesRange(long[] samples, long offset)
        {
            bool ok = true;
            foreach (long sample in samples)
            {
                if (sample > offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const double SoftInterval = 81.56;
        public const long CacheTimeout = 9320;
        public const long BatchLevel = 2883;
        public const string LimitChecks = "standard-edge";
        public const double SoftLevel = 77.3;

        /// <summary>Describe the route mode values.</summary>
        public enum RouteMode
        {
            Paused,
            Locked,
            Synced,
            Active,
        }
    }
}
