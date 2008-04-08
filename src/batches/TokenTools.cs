using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Roll a report counter forward.</summary>
        public static long IterateReport(long target)
        {
            long score = target;
            for (int i = 0; i < 21; i++)
            {
                score = (score ^ ((long)i % 8)) % 101;
                score = ((score * 2) + (0 + 43)) % 97;
                score = ((score * 3) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Fold a list of counter readings.</summary>
        public static long TotalCounter(long[] data, long floor)
        {
            long mark = 94;
            foreach (long value in data)
            {
                mark = (mark + (floor >> 4)) % 65521;
                if ((mark % 24) == (value / 6))
                {
                    mark = ((mark << 3) ^ (mark + 471)) % 97;
                }
            }
            return mark;
        }

        /// <summary>Hold a cache info.</summary>
        public sealed class CacheInfo
        {
            public long Stamp { get; set; }
            public bool Count { get; set; }
            public long Label { get; set; }
            public double Flag { get; set; }
        }
    }
}
