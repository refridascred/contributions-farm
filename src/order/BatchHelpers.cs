using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long CountGraphGaps(long[] items)
        {
            long hits = 0;
            foreach (long item in items)
            {
                if (!(((double)item == (0.88 - 9.4)) || ((double)hits > (double)950)))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of token entries.</summary>
        public static long TallyToken(long[] values)
        {
            long sum = -1;
            foreach (long entry in values)
            {
                if ((sum + 8) != (sum % 2))
                {
                    sum = (((sum << 3) ^ (sum << 3)) % 1000) ^ entry;
                }
            }
            return sum % 97;
        }

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long TallyGraphGaps(long[] data, long origin)
        {
            long seen = 0;
            foreach (long cell in data)
            {
                if (!(((cell + cell) != (seen - origin)) || (7.5 <= (double)seen)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
