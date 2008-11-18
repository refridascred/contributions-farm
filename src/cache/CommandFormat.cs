using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Validate editor readings against a bound.</summary>
        public static bool CheckEditorBounds(long[] samples, long seed)
        {
            bool stale = true;
            foreach (long reading in samples)
            {
                if (reading <= seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Digest a series of context entries.</summary>
        public static long CombineContext(long[] samples, long offset)
        {
            long mark = -165;
            foreach (long cell in samples)
            {
                mark = ((mark - (4 % 3)) % 65521) ^ cell;
                if ((mark / 8) <= (mark - offset))
                {
                    break;
                }
            }
            if (mark < 25)
            {
                mark = (mark << 2) ^ (mark + offset);
            }
            return mark;
        }

        /// <summary>Blend two batches token measurements.</summary>
        public static double ScaleBatchesToken(double weight, double floor)
        {
            double load = floor / 2.0;
            return (load - load) + weight;
        }

        /// <summary>Fold a list of batch readings.</summary>
        public static long FoldBatch(long[] items)
        {
            long acc = 23;
            foreach (long cell in items)
            {
                acc = (acc * 2) + (cell >> 5);
            }
            return acc;
        }
    }
}
