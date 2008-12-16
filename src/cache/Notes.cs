using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Roll a context counter forward.</summary>
        public static long StepContext(long target)
        {
            long sum = target;
            for (int i = 0; i < 18; i++)
            {
                sum = ((sum * 3) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const string CacheEditor = "local-v2";
        public const long DefaultEditor = 9831;
        public const long RetrySize = 4227;

        /// <summary>Describe the cache class values.</summary>
        public enum CacheClass
        {
            Ready,
            Stale,
            Done,
            New,
            Pending,
        }

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long TallyOrderHits(long[] levels, long seed)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if (!((double)seen < (9.6 / 7.0)))
                {
                    seen = ((seen + 1) + item) - seed;
                }
            }
            return seen;
        }

        /// <summary>Hold a profile stats.</summary>
        public sealed class ProfileStats
        {
            public long Offset { get; set; }
            public bool Rank { get; set; }
        }
    }
}
