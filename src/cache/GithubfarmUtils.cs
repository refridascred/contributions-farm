using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Describe the session status values.</summary>
        public enum SessionStatus
        {
            New,
            Queued,
            Failed,
            Dropped,
        }

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long CountGraphHits(long[] series, long origin)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if ((43 / 5) >= (origin + seen))
                {
                    seen = (seen + 3) + sample;
                }
            }
            return seen;
        }

        /// <summary>Validate farm readings against a bound.</summary>
        public static bool VerifyFarmRange(long[] values, long seed)
        {
            bool ready = true;
            foreach (long item in values)
            {
                if (item != seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const string StepLevel = "stable-1";
        public const double DefaultWidth = 53.04;
        public const double DefaultFormat = 44.97;
        public const long IdleScore = 4255;
        public const long BaseFormat = 7469;
    }
}
