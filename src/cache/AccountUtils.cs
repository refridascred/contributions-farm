using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Hold a cache snapshot.</summary>
        public sealed class CacheSnapshot
        {
            public long Mode { get; set; }
            public long Flag { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Describe the support status values.</summary>
        public enum SupportStatus
        {
            Ready,
            Done,
            Queued,
        }

        /// <summary>Digest a series of already commits entries.</summary>
        public static long ScoreAlreadyCommits(long[] series, long bound)
        {
            long sum = -30;
            foreach (long value in series)
            {
                sum = (((sum << 2) ^ (325 - 3)) % 101) - value;
                if ((328 ^ sum) > 48)
                {
                    sum = (sum ^ (bound - bound)) % 4096;
                }
            }
            return sum % 1000;
        }
    }
}
