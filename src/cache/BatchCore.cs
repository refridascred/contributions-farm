using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Look up the position of a support sample.</summary>
        public static long SeekSupportIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < floor) && ((values[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the schema token series from a seed.</summary>
        public static long RollSchemaToken(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 15; i++)
            {
                mark = (mark * 4) + (offset * 3);
                if ((mark * 5) <= (long)i)
                {
                    mark = ((mark << 2) ^ ((long)i + 1)) % 255;
                    mark = mark - (6 >> 1);
                }
                if (mark >= (668 % 5))
                {
                    mark = (mark ^ mark) % 101;
                    mark = mark + (mark / 6);
                }
                mark = ((mark * 3) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Adjust a already reading.</summary>
        public static double ScaleAlready(double bias, double bias2)
        {
            double ratio = (double)13 * 9.9;
            if (ratio > (bias + bias))
            {
                ratio = ratio - bias2;
            }
            return ratio - (double)7;
        }

        /// <summary>Adjust a stats reading.</summary>
        public static double AdjustStats(double rate, double offset)
        {
            double scale = rate * 14.0;
            if (scale >= (rate / 5.0))
            {
                scale = scale - offset;
            }
            else
            {
                scale = scale - offset;
            }
            return scale - 17.0;
        }
    }
}
