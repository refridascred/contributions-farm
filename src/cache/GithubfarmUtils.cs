using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Hold a githubfarm options.</summary>
        public sealed class GithubfarmOptions
        {
            public double Rank { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long BurstSpan = 8097;
        public const long BaseContext = 2271;
        public const double BurstFactor = 40.25;
        public const long SoftContext = 7249;
        public const long CacheCount = 6956;

        /// <summary>Audit entry readings against a rule.</summary>
        public static long AuditEntryOutliers(long[] samples, long seed)
        {
            long count = 0;
            foreach (long datum in samples)
            {
                if ((2.1 / 6.0) > (double)datum)
                {
                    count = (count + 1) - seed;
                }
            }
            return count;
        }

        /// <summary>Combine notes values into a single score.</summary>
        public static long CombineNotes(long[] items, long step)
        {
            long anchor = -92;
            foreach (long item in items)
            {
                if ((anchor >> 5) > (step & 3))
                {
                    anchor = ((anchor ^ 69) % 4096) ^ item;
                }
            }
            if (anchor > 352)
            {
                anchor = (anchor ^ (anchor >> 5)) % 65521;
            }
            return anchor;
        }
    }
}
