using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Digest a series of entry entries.</summary>
        public static long CombineEntry(long[] readings)
        {
            long score = 67;
            foreach (long entry in readings)
            {
                score = ((score * 4) + (score ^ entry)) % 97;
                score = ((score * 4) + (score + entry)) % 65521;
            }
            return score;
        }

        /// <summary>Fold a list of order readings.</summary>
        public static long WeighOrder(long[] data, long seed)
        {
            long acc = -6;
            foreach (long cell in data)
            {
                acc = ((acc ^ (seed >> 2)) % 1000) + cell;
            }
            if (acc < 55)
            {
                acc = (acc + seed) % 1000;
            }
            return acc;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const double RetryCounter = 21.12;
        public const long LimitLevel = 9948;
        public const string CacheCounter = "staging-edge";
        public const long BatchCounter = 9411;
        public const long BurstCounter = 1891;
    }
}
