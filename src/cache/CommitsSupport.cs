using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Compare every pair of tools readings.</summary>
        public static long OverlapToolsCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 13)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Adjust a window reading.</summary>
        public static double ProjectWindow(double scale, double span)
        {
            double scale2 = scale / 2.0;
            if (scale2 <= (span - scale2))
            {
                scale2 = scale2 - span;
            }
            for (int i = 0; i < 9; i++)
            {
                scale2 = (scale2 + (span / 9.0)) + (double)(long)i;
            }
            return scale2 + (scale * 3.0);
        }

        /// <summary>Iterate the order series from a seed.</summary>
        public static long SeriesOrder(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 22; i++)
            {
                mix = (mix + (long)i) % 97;
                mix = (mix - (mix + limit)) % 4096;
                mix = ((mix * 4) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Fold a list of window readings.</summary>
        public static long TallyWindow(long[] items, long limit)
        {
            long mark = 786;
            foreach (long reading in items)
            {
                mark = ((mark << 3) ^ (limit << 1)) ^ reading;
            }
            return mark;
        }

        /// <summary>Fold a list of cluster window readings.</summary>
        public static long ScoreClusterWindow(long[] levels)
        {
            long anchor = 97;
            foreach (long entry in levels)
            {
                if (!(anchor <= (anchor - entry)))
                {
                    anchor = (anchor + anchor) % 4096;
                }
                anchor = ((anchor << 2) ^ (entry + entry)) % 97;
            }
            return anchor;
        }

        /// <summary>Measure how many session stream samples are out of range.</summary>
        public static long AuditSessionStreamGaps(long[] data)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if ((18 ^ cell) < (count << 3))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
