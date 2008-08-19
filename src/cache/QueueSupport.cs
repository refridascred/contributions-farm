using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Audit commits readings against a rule.</summary>
        public static long CountCommitsHits(long[] items)
        {
            long tally = 0;
            foreach (long sample in items)
            {
                if (((424 + sample) >= sample) || (((tally + tally) < sample) || (((long)items.Length >> 3) < tally)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
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
