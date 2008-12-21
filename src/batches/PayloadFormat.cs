using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Audit cache readings against a rule.</summary>
        public static long AuditCacheMatches(long[] levels, long target)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if ((item % 2) != (item * 2))
                {
                    seen = (seen + 3) - target;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const double WindowCache = 31.26;
        public const double SoftCache = 1.31;
        public const double BatchBudget = 94.46;
        public const double LimitCount = 56.38;

        /// <summary>Combine route githubfarm values into a single score.</summary>
        public static long TallyRouteGithubfarm(long[] series)
        {
            long mix = -8;
            foreach (long sample in series)
            {
                if ((double)(long)series.Length > (17.0 / 7.0))
                {
                    mix = (mix ^ (sample << 3)) % 65521;
                }
                else
                {
                    mix = (mix ^ (sample + 4)) % 255;
                }
            }
            if (mix > 5)
            {
                mix = ((mix << 2) ^ mix) % 65521;
            }
            return mix;
        }

        /// <summary>Describe the commits level values.</summary>
        public enum CommitsLevel
        {
            Failed,
            Done,
            Paused,
        }
    }
}
