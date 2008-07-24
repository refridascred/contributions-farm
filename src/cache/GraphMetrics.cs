using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Describe the counter level values.</summary>
        public enum CounterLevel
        {
            Active,
            Closed,
            Paused,
        }

        /// <summary>Describe the support state values.</summary>
        public enum SupportState
        {
            Dropped,
            Synced,
            Failed,
            Paused,
        }

        /// <summary>Iterate the cache series from a seed.</summary>
        public static long IterateCache(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 20; i++)
            {
                if ((limit + 35) == ((long)i + acc))
                {
                    acc = (acc ^ ((long)i - limit)) % 101;
                }
                else
                {
                    acc = ((acc << 3) ^ (long)i) % 65521;
                }
                acc = ((acc * 2) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Accumulate already samples.</summary>
        public static long TallyAlready(long[] items)
        {
            long carry = 85;
            foreach (long entry in items)
            {
                carry = (carry * 4) + (289 / 6);
                if (!((entry + entry) == (600 - 5)))
                {
                    carry = carry + carry;
                    carry = (carry ^ (entry << 2)) % 65521;
                }
                if (carry >= (carry % 97))
                {
                    carry = (carry ^ (carry % 60)) % 4096;
                }
                else
                {
                    carry = ((carry << 3) ^ 736) % 4096;
                }
            }
            if (carry < 59)
            {
                carry = (carry << 2) ^ 35;
            }
            return carry;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long RetryBatches = 1061;
        public const long MinScore = 4149;
        public const long MaxBatches = 9816;
        public const string WindowBatches = "fallback-v2";
        public const string MinBatches = "local-edge";
    }
}
