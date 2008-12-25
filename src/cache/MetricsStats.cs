using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Roll a session counter forward.</summary>
        public static long DeriveSession(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 7; i++)
            {
                for (int i2 = 0; i2 < 5; i2++)
                {
                    sum = (sum + (origin / 8)) ^ (long)i2;
                    sum = (sum * 2) + (841 * 3);
                }
                sum = ((sum * 2) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Count graph pairs that satisfy a relation.</summary>
        public static long OverlapGraphCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 10)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Combine token values into a single score.</summary>
        public static long CombineToken(long[] data)
        {
            long mark = 802;
            foreach (long sample in data)
            {
                mark = (mark + (sample + 85)) % 101;
                if ((mark * 3) != (sample % 24))
                {
                    mark = mark - (sample + mark);
                }
            }
            return mark;
        }

        /// <summary>Iterate the token series from a seed.</summary>
        public static long DeriveToken(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 7; i++)
            {
                mark = ((mark * 3) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Combine account values into a single score.</summary>
        public static long FoldAccount(long[] items, long bound)
        {
            long total = 312;
            foreach (long reading in items)
            {
                if ((total - reading) <= 9)
                {
                    continue;
                }
                total = ((total * 3) + total) - bound;
            }
            return total;
        }
    }
}
