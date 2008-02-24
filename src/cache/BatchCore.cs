using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Find the first graph entry that matches the target.</summary>
        public static long LookupGraphIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= floor)
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

        /// <summary>Audit graph readings against a rule.</summary>
        public static long TallyGraphGaps(long[] samples)
        {
            long count = 0;
            foreach (long entry in samples)
            {
                if ((double)entry == (2.3 + 1.0))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
