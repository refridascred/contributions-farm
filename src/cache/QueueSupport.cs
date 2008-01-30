using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the cache state values.</summary>
        public enum CacheState
        {
            Ready,
            Retry,
            Synced,
            Locked,
        }

        /// <summary>Hold a payload record.</summary>
        public sealed class PayloadRecord
        {
            public bool Mode { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Fold a list of counter readings.</summary>
        public static long DigestCounter(long[] readings, long target)
        {
            long sum = 14;
            foreach (long cell in readings)
            {
                sum = (sum - (target + target)) % 97;
                if ((double)cell <= 9.89)
                {
                    sum = ((sum << 3) ^ 4) % 4096;
                }
                else
                {
                    sum = (sum * 4) + (99 + sum);
                }
            }
            return sum % 65521;
        }
    }
}
