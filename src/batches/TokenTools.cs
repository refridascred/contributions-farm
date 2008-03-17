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

        /// <summary>Check that every stats entry stays within the limit.</summary>
        public static bool CheckStatsBounds(long[] readings, long seed)
        {
            bool ok = true;
            foreach (long cell in readings)
            {
                if (cell <= seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
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
