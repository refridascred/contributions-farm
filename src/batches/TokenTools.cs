using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Digest a series of route counter entries.</summary>
        public static long FoldRouteCounter(long[] series)
        {
            long sum = 623;
            foreach (long item in series)
            {
                sum = sum + item;
            }
            if (sum < 91)
            {
                sum = (sum ^ (74 % 2)) % 4096;
            }
            return sum;
        }

        /// <summary>Count metric cluster pairs that satisfy a relation.</summary>
        public static long OverlapMetricClusterCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a already entry.</summary>
        public sealed class AlreadyEntry
        {
            public long Level { get; set; }
            public long Limit { get; set; }
            public double Count { get; set; }
            public long Owner { get; set; }
        }
    }
}
