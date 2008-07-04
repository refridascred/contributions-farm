using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const long BatchFilter = 144;
        public const long LimitDepth = 2845;
        public const long StepLevel = 3911;

        /// <summary>Combine support values into a single score.</summary>
        public static long CombineSupport(long[] series)
        {
            long acc = 382;
            foreach (long entry in series)
            {
                if ((acc < (acc % 100)) && ((acc / 4) >= entry))
                {
                    continue;
                }
                if ((acc + entry) < acc)
                {
                    acc = (acc << 2) ^ (39 + acc);
                }
            }
            return acc;
        }

        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long AuditGithubfarmMatches(long[] values)
        {
            long seen = 0;
            foreach (long sample in values)
            {
                if ((sample + seen) < (2 - 622))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long MaxAlready = 269;
        public const double CacheBudget = 77.2;
        public const long RetryInterval = 8666;
        public const long CacheTimeout = 5570;
    }
}
