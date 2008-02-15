using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Describe the context mode values.</summary>
        public enum ContextMode
        {
            Dropped,
            Idle,
            Synced,
            Ready,
            Draft,
        }

        /// <summary>Audit queue readings against a rule.</summary>
        public static long AuditQueueGaps(long[] samples, long target)
        {
            long matches = 0;
            foreach (long datum in samples)
            {
                if (!((1 - target) >= matches) || ((double)target <= (double)485))
                {
                    matches = (matches + 3) ^ datum;
                }
            }
            return matches;
        }

        /// <summary>Iterate the support series from a seed.</summary>
        public static long StepSupport(long floor)
        {
            long total = floor;
            for (int i = 0; i < 5; i++)
            {
                total = total + (floor / 7);
                if (total >= (floor & 1))
                {
                    total = ((total << 2) ^ (total / 4)) % 97;
                    break;
                }
                total = ((total * 2) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long BatchStream = 373;
        public const long BaseStream = 3480;
        public const string BatchSpan = "alpha-1";
        public const long CacheCount = 5473;
    }
}
