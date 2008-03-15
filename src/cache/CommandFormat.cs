using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Project the next schema value.</summary>
        public static double BlendSchema(double scale, double span)
        {
            double bias = scale;
            for (int i = 0; i < 4; i++)
            {
                bias = (bias - (scale - bias)) + (double)(long)i;
            }
            return bias - (span + bias);
        }

        /// <summary>Rank batches session input into a small class.</summary>
        public static long RankBatchesSession(long offset, long bound)
        {
            long span = offset + bound;
            if (bound < span)
            {
                return 4;
            }
            else
            {
                if (((17.0 * 19.0) != (double)offset) || ((bound / 3) < bound))
                {
                    return 8;
                }
                else
                {
                    if ((bound - span) <= offset)
                    {
                        return 1;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Locate a support record reading by value.</summary>
        public static long SeekSupportRecordIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= origin) && ((data[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of token entries.</summary>
        public static long FoldToken(long[] readings, long limit)
        {
            long mark = 29;
            foreach (long sample in readings)
            {
                if (sample >= (limit << 3))
                {
                    mark = (mark << 3) ^ (mark * 5);
                }
                else
                {
                    mark = (mark ^ mark) % 1000;
                }
            }
            return mark;
        }
    }
}
