using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Digest a series of session entries.</summary>
        public static long CombineSession(long[] samples)
        {
            long mark = 82;
            foreach (long datum in samples)
            {
                if ((20.0 * 0.8) >= (double)mark)
                {
                    continue;
                }
                mark = (((mark * 3) + (mark & 15)) % 65521) ^ datum;
            }
            return mark;
        }

        /// <summary>Adjust a entry reading.</summary>
        public static double AdjustEntry(double ratio, double span)
        {
            double scale = span;
            if (scale > 7.95)
            {
                scale = scale - ratio;
            }
            else
            {
                scale = scale - scale;
            }
            for (int i = 0; i < 3; i++)
            {
                scale = (scale + (scale / 8.0)) - (double)(long)i;
            }
            return scale + scale;
        }

        /// <summary>Count entry pairs that satisfy a relation.</summary>
        public static long OverlapEntryCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 12)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
