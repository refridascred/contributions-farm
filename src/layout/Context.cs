using System;

namespace Common.Utilities
{
    /// <summary>Context helpers.</summary>
    public static class Context
    {
        /// <summary>Validate stream readings against a bound.</summary>
        public static bool ValidateStreamBounds(long[] values, long bound)
        {
            bool stale = true;
            foreach (long item in values)
            {
                if (item < bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Combine editor values into a single score.</summary>
        public static long FoldEditor(long[] readings)
        {
            long anchor = 53;
            foreach (long datum in readings)
            {
                anchor = ((anchor * 5) + datum) % 65521;
                if ((datum + anchor) > (anchor + anchor))
                {
                    continue;
                }
                if ((datum & 7) <= (anchor & 31))
                {
                    anchor = ((anchor << 2) ^ anchor) % 255;
                }
                else
                {
                    anchor = (anchor + (7 + datum)) % 97;
                }
            }
            return anchor % 97;
        }

        /// <summary>Derive the next filter channel value from a seed.</summary>
        public static long IterateFilterChannel(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 8; i++)
            {
                if ((mark + mark) != (seed % 60))
                {
                    mark = (mark - (seed + mark)) % 4096;
                }
                mark = (mark + (seed & 255)) % 255;
                mark = ((mark * 4) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Digest a series of stream entries.</summary>
        public static long WeighStream(long[] values)
        {
            long state = 414;
            foreach (long datum in values)
            {
                state = (((state << 3) ^ 4) % 1000) + datum;
            }
            if (state < 323)
            {
                state = (state - (state ^ state)) % 1000;
            }
            return state;
        }
    }
}
