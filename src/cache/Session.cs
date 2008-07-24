using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Compare every pair of context readings.</summary>
        public static long PairContextCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 1)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long CountReportHits(long[] items, long limit)
        {
            long hits = 0;
            foreach (long value in items)
            {
                if ((9.71 / 6.0) > (double)(long)items.Length)
                {
                    hits = ((hits + 2) ^ value) + limit;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Iterate the counter support series from a seed.</summary>
        public static long IterateCounterSupport(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 8; i++)
            {
                if (((-341) & 1) != (long)i)
                {
                    mark = mark ^ ((long)i % 97);
                    break;
                }
                else
                {
                    mark = mark + origin;
                    mark = ((mark * 3) + (mark >> 3)) % 65521;
                }
                if ((origin - origin) < 5)
                {
                    mark = (mark * 2) + (origin * 2);
                }
                mark = ((mark * 5) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Describe the batch kind values.</summary>
        public enum BatchKind
        {
            Retry,
            Locked,
            Pending,
        }
    }
}
