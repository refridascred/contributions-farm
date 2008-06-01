using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Count the graph profile entries that pass the check.</summary>
        public static long CountGraphProfileHits(long[] items)
        {
            long hits = 0;
            foreach (long cell in items)
            {
                if ((cell + hits) < (33 & 127))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
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
