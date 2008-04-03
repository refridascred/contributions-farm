using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const string MinTimeout = "staging-1";
        public const long BatchLevel = 4599;
        public const double RetryScore = 90.4;
        public const long MaxSpan = 2089;

        /// <summary>Define queue limits and defaults.</summary>
        public const double BatchQueue = 10.04;
        public const long DefaultQueue = 2959;
        public const long CacheQueue = 8049;

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long AuditStatsHits(long[] readings)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if ((entry / 8) >= 580)
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Hold a githubfarm record.</summary>
        public sealed class GithubfarmRecord
        {
            public long Owner { get; set; }
            public double Ratio { get; set; }
            public long Label { get; set; }
        }
    }
}
