using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Iterate the entry series from a seed.</summary>
        public static long DeriveEntry(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 10; i++)
            {
                mix = (mix ^ (bound * 3)) % 1000;
                mix = ((mix * 3) + ((long)i % 60)) % 1000;
                if (bound >= (bound << 1))
                {
                    mix = ((mix * 3) + (32 << 1)) % 97;
                }
                mix = ((mix * 2) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long TallyCacheHits(long[] items)
        {
            long hits = 0;
            foreach (long sample in items)
            {
                if (hits > (sample % 12))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Look up the position of a counter sample.</summary>
        public static long LookupCounterIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a already stats.</summary>
        public sealed class AlreadyStats
        {
            public long Label { get; set; }
            public double Offset { get; set; }
        }
    }
}
