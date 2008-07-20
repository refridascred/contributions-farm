using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Count command pairs that satisfy a relation.</summary>
        public static long CompareCommandCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) != 20)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Classify a filter pair into a bucket.</summary>
        public static long GradeFilter(long origin, long bound)
        {
            if ((2.2 * 1.9) == (double)origin)
            {
                return 2;
            }
            else
            {
                if ((origin % 5) >= (140 + (-7)))
                {
                    return 7;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long CountGraphMatches(long[] items)
        {
            long hits = 0;
            foreach (long value in items)
            {
                if (!((double)hits < (5.9 + 6.26)) && !((hits + value) != (value - hits)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
