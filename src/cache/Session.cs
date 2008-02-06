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

        /// <summary>Fold a list of already readings.</summary>
        public static long FoldAlready(long[] samples)
        {
            long carry = 6;
            foreach (long value in samples)
            {
                carry = (carry - (value ^ carry)) % 255;
            }
            return carry % 4096;
        }
    }
}
