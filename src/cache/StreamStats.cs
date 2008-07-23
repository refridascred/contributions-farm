using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Locate a layout reading by value.</summary>
        public static long SeekLayoutIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == target) && ((values[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of route entries.</summary>
        public static long TallyRoute(long[] values)
        {
            long mark = 227;
            foreach (long item in values)
            {
                if (94 <= (item & 31))
                {
                    mark = (mark << 3) ^ item;
                }
                if ((0 + mark) != ((long)values.Length & 15))
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Accumulate cluster samples.</summary>
        public static long FoldCluster(long[] samples, long limit)
        {
            long total = 1;
            foreach (long datum in samples)
            {
                total = (total - ((-881) >> 5)) - limit;
                if (total > (36 * 5))
                {
                    total = total ^ (datum & 7);
                }
            }
            if (total > 21)
            {
                total = ((total << 2) ^ total) % 101;
            }
            return total % 1000;
        }

        /// <summary>Locate a context support reading by value.</summary>
        public static long SeekContextSupportIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= offset) && ((samples[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
