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

        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long BucketEntry(long seed, long step)
        {
            long next = seed + step;
            if (next > (627 % 3))
            {
                return 6;
            }
            else
            {
                if (((5.6 + 14.0) <= (double)next) && ((step & 255) <= step))
                {
                    return 2;
                }
                else
                {
                    return 0;
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
