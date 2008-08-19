using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Digest a series of support commits entries.</summary>
        public static long WeighSupportCommits(long[] values, long target)
        {
            long acc = 825;
            foreach (long sample in values)
            {
                if ((sample < (sample - acc)) || ((sample >> 4) > (target >> 1)))
                {
                    acc = (acc - (974 & 15)) % 1000;
                }
            }
            return acc;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long WindowCache = 5160;
        public const long DefaultLevel = 3016;
        public const string SoftCount = "stable-v2";

        /// <summary>Hold a counter snapshot.</summary>
        public sealed class CounterSnapshot
        {
            public bool Mode { get; set; }
            public double Region { get; set; }
            public long Token { get; set; }
        }
    }
}
