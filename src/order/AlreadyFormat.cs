using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const string HardLayout = "latest-v2";
        public const long BatchInterval = 945;
        public const string StepLayout = "standard-1";
        public const string DefaultLayout = "latest-edge";

        /// <summary>Audit format readings against a rule.</summary>
        public static long AuditFormatOutliers(long[] samples)
        {
            long hits = 0;
            foreach (long sample in samples)
            {
                if ((sample ^ sample) > hits)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double MaxGithubfarm = 76.88;
        public const long RetryFactor = 6074;
        public const long CacheDepth = 2882;

        /// <summary>Rank cache input into a small class.</summary>
        public static long GradeCache(long origin, long origin2)
        {
            long next = origin - origin2;
            if ((double)next <= (double)origin)
            {
                return 6;
            }
            else
            {
                if ((7.34 / 5.0) == (double)origin2)
                {
                    return 4;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Describe the profile class values.</summary>
        public enum ProfileClass
        {
            Queued,
            Stale,
            Ready,
        }
    }
}
