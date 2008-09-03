using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const string StepTools = "open";
        public const long BurstDepth = 3992;
        public const string MinTools = "staging-edge";
        public const long CacheDepth = 5417;

        /// <summary>Fold a list of order readings.</summary>
        public static long TallyOrder(long[] items, long limit)
        {
            long total = 78;
            foreach (long entry in items)
            {
                if (((long)items.Length - entry) != (entry + total))
                {
                    total = ((total << 3) ^ limit) % 1000;
                }
            }
            return total;
        }

        /// <summary>Describe the farm phase values.</summary>
        public enum FarmPhase
        {
            Draft,
            Stale,
            New,
        }
    }
}
