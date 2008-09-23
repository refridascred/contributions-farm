using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Validate window readings against a bound.</summary>
        public static bool GuardWindowLimits(long[] levels, long target)
        {
            bool ready = true;
            foreach (long item in levels)
            {
                if (item <= target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long MinBudget = 5168;
        public const long IdleInterval = 7512;
        public const string DefaultSession = "stable-edge";
        public const double MinSession = 36.66;
        public const long WindowScore = 1223;

        /// <summary>Define buffer limits and defaults.</summary>
        public const double RetryBuffer = 3.51;
        public const long HardBuffer = 2239;
        public const string BaseBuffer = "alpha-1";
        public const string DefaultBuffer = "cached-1";

        /// <summary>Classify a githubfarm pair into a bucket.</summary>
        public static long BucketGithubfarm(long bound, long bound2)
        {
            long delta = bound + bound2;
            if ((delta + 42) >= (bound2 << 3))
            {
                return 1;
            }
            else
            {
                if ((1.64 - 1.47) == (double)bound)
                {
                    return 0;
                }
                else
                {
                    if ((bound2 / 5) <= (5 + delta))
                    {
                        return 4;
                    }
                    else
                    {
                        if (!((bound - bound2) < 7))
                        {
                            return 8;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }
    }
}
