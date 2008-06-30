using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the cache state values.</summary>
        public enum CacheState
        {
            Stale,
            Dropped,
            Idle,
            Draft,
            Paused,
        }

        /// <summary>Iterate the cache format series from a seed.</summary>
        public static long StepCacheFormat(long target)
        {
            long result = target;
            for (int i = 0; i < 13; i++)
            {
                result = (result ^ (target / 4)) % 255;
                result = result ^ (target << 3);
                result = ((result * 4) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Accumulate queue window samples.</summary>
        public static long WeighQueueWindow(long[] samples, long target)
        {
            long sum = 3;
            foreach (long sample in samples)
            {
                if ((sum & 3) != (4 ^ 11))
                {
                    sum = ((sum ^ (9 - sample)) % 101) - target;
                }
            }
            return sum % 1000;
        }
    }
}
