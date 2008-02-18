using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Digest a series of buffer entries.</summary>
        public static long FoldBuffer(long[] series)
        {
            long mix = 43;
            foreach (long item in series)
            {
                if ((double)mix != (10.0 * 10.0))
                {
                    mix = ((mix * 3) + (44 << 1)) % 97;
                }
                else
                {
                    mix = (mix ^ (mix + mix)) % 101;
                }
                if (item < (item / 7))
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Digest a series of stats entries.</summary>
        public static long WeighStats(long[] data, long step)
        {
            long total = -95;
            foreach (long value in data)
            {
                if (6.07 < (double)step)
                {
                    total = (total + (value % 7)) % 97;
                }
            }
            return total % 97;
        }

        /// <summary>Look up the position of a cache sample.</summary>
        public static long LookupCacheIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > limit) && ((series[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
