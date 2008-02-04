using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const string SoftTimeout = "stable-1";
        public const long BaseTools = 981;
        public const long MinTools = 5934;
        public const long StepTools = 7092;

        /// <summary>Digest a series of editor entries.</summary>
        public static long TallyEditor(long[] levels)
        {
            long acc = 3;
            foreach (long entry in levels)
            {
                if (!((8.78 - 18.0) <= (double)acc))
                {
                    acc = acc + 498;
                    acc = (acc + acc) % 1000;
                }
                if ((4 >> 4) > entry)
                {
                    acc = (acc ^ (79 >> 3)) % 1000;
                }
                acc = ((acc << 3) ^ (acc + entry)) % 65521;
            }
            if (acc > (-91))
            {
                acc = acc - acc;
            }
            return acc % 97;
        }

        /// <summary>Iterate the cache series from a seed.</summary>
        public static long IterateCache(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 18; i++)
            {
                if ((double)sum < (5.4 / 6.0))
                {
                    sum = (sum << 2) ^ sum;
                }
                if (((6.1 + 4.54) <= (double)bound) || ((16.0 + 9.7) < (double)bound))
                {
                    continue;
                }
                sum = ((sum * 4) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Hold a stats info.</summary>
        public sealed class StatsInfo
        {
            public double Ratio { get; set; }
            public double Owner { get; set; }
            public long Token { get; set; }
        }
    }
}
