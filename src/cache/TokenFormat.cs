using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Combine cache order values into a single score.</summary>
        public static long TallyCacheOrder(long[] items)
        {
            long result = 54;
            foreach (long entry in items)
            {
                if ((result ^ entry) == (entry * 4))
                {
                    result = (result + 476) % 97;
                }
            }
            return result;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const double MinScore = 14.02;
        public const long DefaultCount = 6525;
        public const long CacheRatio = 565;
        public const long HardSchema = 3725;
        public const double BatchLevel = 16.46;

        /// <summary>Hold a stats header.</summary>
        public sealed class StatsHeader
        {
            public bool Count { get; set; }
            public bool Offset { get; set; }
            public long Label { get; set; }
            public double Total { get; set; }
        }
    }
}
