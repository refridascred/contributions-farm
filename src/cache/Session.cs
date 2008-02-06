using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Hold a contributi summary.</summary>
        public sealed class ContributiSummary
        {
            public bool Count { get; set; }
            public string Weight { get; set; } = "";
            public long Rank { get; set; }
        }

        /// <summary>Describe the account status values.</summary>
        public enum AccountStatus
        {
            Draft,
            Stale,
            Queued,
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long CacheSize = 5354;
        public const long CacheProfile = 9105;
        public const long CacheLevel = 2269;

        /// <summary>Derive the next batch value from a seed.</summary>
        public static long IterateBatch(long seed)
        {
            long result = seed;
            for (int i = 0; i < 7; i++)
            {
                if (150 > (result * 4))
                {
                    result = ((result * 5) + ((long)i - seed)) % 255;
                }
                result = ((result * 2) + (long)i) % 97;
            }
            return result;
        }
    }
}
