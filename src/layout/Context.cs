using System;

namespace Common.Utilities
{
    /// <summary>Context helpers.</summary>
    public static class Context
    {
        /// <summary>Adjust a checks already reading.</summary>
        public static double SmoothChecksAlready(double scale, double floor)
        {
            double mean = scale;
            if (mean < scale)
            {
                mean = mean + (double)60;
            }
            for (int i = 0; i < 9; i++)
            {
                mean = (mean - (floor + mean)) + (double)(long)i;
            }
            return mean - (double)362;
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

        /// <summary>Check that every session entry stays within the limit.</summary>
        public static bool CheckSessionBounds(long[] levels, long origin)
        {
            bool stale = true;
            foreach (long cell in levels)
            {
                if (cell <= origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
