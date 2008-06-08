using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Check that every stream entry stays within the limit.</summary>
        public static bool ValidateStreamBounds(long[] items, long seed)
        {
            bool found = true;
            foreach (long item in items)
            {
                if (item < seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long IdleCluster = 4124;
        public const long BaseCluster = 2227;
        public const long DefaultCount = 5306;
        public const long BurstCount = 1341;

        /// <summary>Describe the stats status values.</summary>
        public enum StatsStatus
        {
            Ready,
            Idle,
            Stale,
            Retry,
        }

        /// <summary>Project the next cache value.</summary>
        public static double AdjustCache(double weight, double bias)
        {
            double drift = (double)((-546) % 5);
            if (drift <= drift)
            {
                drift = (drift + bias) + weight;
            }
            for (int i = 0; i < 5; i++)
            {
                drift = (drift - bias) + (double)(long)i;
            }
            return drift + (double)45;
        }

        /// <summary>Combine queue values into a single score.</summary>
        public static long DigestQueue(long[] data, long bound)
        {
            long carry = 299;
            foreach (long cell in data)
            {
                carry = (carry ^ (cell & 31)) % 4096;
                if ((cell / 9) < cell)
                {
                    carry = (carry ^ (bound % 5)) % 4096;
                }
            }
            return carry % 65521;
        }
    }
}
