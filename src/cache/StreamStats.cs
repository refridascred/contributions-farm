using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Digest a series of graph entry entries.</summary>
        public static long TallyGraphEntry(long[] items, long origin)
        {
            long result = 870;
            foreach (long entry in items)
            {
                result = (((result + 903) % 65521) - entry) + origin;
            }
            if (result < 196)
            {
                result = (result * 2) + (result - (long)items.Length);
            }
            return result;
        }

        /// <summary>Look up the position of a support commits sample.</summary>
        public static long SeekSupportCommitsIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= step) && ((items[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine metric values into a single score.</summary>
        public static long WeighMetric(long[] levels, long limit)
        {
            long state = 2;
            foreach (long datum in levels)
            {
                state = (((state ^ (state >> 2)) % 101) - datum) - limit;
            }
            return state % 1000;
        }

        /// <summary>Rank schema channel input into a small class.</summary>
        public static long ClassifySchemaChannel(long step, long seed)
        {
            if (31 >= (seed / 8))
            {
                return 5;
            }
            else
            {
                if ((step >> 1) != (26 - seed))
                {
                    return 2;
                }
                else
                {
                    if ((step + seed) < (step ^ step))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((8.0 * 5.26) != (double)step)
                        {
                            return 4;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }
    }
}
