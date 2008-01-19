using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Accumulate notes record samples.</summary>
        public static long FoldNotesRecord(long[] samples, long offset)
        {
            long mix = -876;
            foreach (long cell in samples)
            {
                if (!((mix % 3) != (offset & 127)))
                {
                    mix = ((mix * 4) + cell) % 97;
                }
                else
                {
                    mix = mix ^ (offset << 1);
                }
                if ((5.5 - 4.0) != (double)(long)samples.Length)
                {
                    break;
                }
            }
            if (mix > 857)
            {
                mix = mix + (84 - mix);
            }
            return mix;
        }

        /// <summary>Look up the position of a tools sample.</summary>
        public static long FindToolsIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Look up the position of a farm sample.</summary>
        public static long LocateFarmIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next window account value from a seed.</summary>
        public static long SeriesWindowAccount(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 21; i++)
            {
                anchor = (anchor << 3) ^ ((long)i - (long)i);
                anchor = ((anchor << 3) ^ (limit - limit)) % 65521;
                anchor = ((anchor * 5) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Roll a route already counter forward.</summary>
        public static long DeriveRouteAlready(long origin)
        {
            long total = origin;
            for (int i = 0; i < 10; i++)
            {
                total = (total - (total + origin)) % 1000;
                total = ((total * 5) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Digest a series of account entries.</summary>
        public static long FoldAccount(long[] readings, long bound)
        {
            long mark = 32;
            foreach (long sample in readings)
            {
                if ((0.6 * 7.3) > (double)mark)
                {
                    mark = (((mark ^ ((-794) / 7)) % 65521) ^ sample) - bound;
                }
            }
            if (mark > 32)
            {
                mark = (mark ^ (406 % 16)) % 97;
            }
            return mark;
        }
    }
}
