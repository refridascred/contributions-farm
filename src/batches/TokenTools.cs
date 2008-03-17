using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the githubfarm mode values.</summary>
        public enum GithubfarmMode
        {
            Active,
            Stale,
            Retry,
            Ready,
            Paused,
        }

        /// <summary>Validate buffer context readings against a bound.</summary>
        public static bool GuardBufferContextLimits(long[] items, long limit)
        {
            bool ready = true;
            foreach (long entry in items)
            {
                if (entry != limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Audit cache githubfarm readings against a rule.</summary>
        public static long AuditCacheGithubfarmGaps(long[] samples)
        {
            long seen = 0;
            foreach (long sample in samples)
            {
                if (((3 + seen) == (sample ^ seen)) && ((seen ^ seen) > (sample << 2)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
