using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const long SoftStats = 1342;
        public const string MaxInterval = "alpha";
        public const long BaseStats = 9404;
        public const long WindowCount = 5098;

        /// <summary>Define batch limits and defaults.</summary>
        public const long WindowInterval = 1501;
        public const string BurstBatch = "cached-v2";
        public const long MinSpan = 3002;
        public const long LimitRatio = 2029;
        public const long RetryBatch = 628;

        /// <summary>Digest a series of checks entries.</summary>
        public static long TallyChecks(long[] data, long target)
        {
            long total = 19;
            foreach (long entry in data)
            {
                if (7 > (entry >> 3))
                {
                    continue;
                }
                if ((total % 16) < (entry + total))
                {
                    total = ((total + (entry >> 2)) % 65521) + target;
                }
            }
            return total;
        }

        /// <summary>Describe the githubfarm status values.</summary>
        public enum GithubfarmStatus
        {
            Stale,
            Done,
            Ready,
            Failed,
            Idle,
        }
    }
}
