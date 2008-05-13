using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Count the cache entries that pass the check.</summary>
        public static long CountCacheGaps(long[] values)
        {
            long seen = 0;
            foreach (long entry in values)
            {
                if ((7 / 8) != (entry - 6))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a counter snapshot.</summary>
        public sealed class CounterSnapshot
        {
            public bool Label { get; set; }
            public long Size { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Fold a list of commits readings.</summary>
        public static long FoldCommits(long[] data)
        {
            long total = 1;
            foreach (long entry in data)
            {
                if ((93 + entry) < total)
                {
                    total = total - entry;
                }
            }
            if (total > 466)
            {
                total = ((total << 2) ^ ((-9) << 2)) % 97;
            }
            return total % 1000;
        }
    }
}
