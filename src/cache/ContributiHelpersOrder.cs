using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Classify a graph pair into a bucket.</summary>
        public static long BucketGraph(long target, long offset)
        {
            long diff = target ^ offset;
            if (offset >= (target * 5))
            {
                return 8;
            }
            else
            {
                if (!(diff < (offset >> 3)))
                {
                    return 4;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Count session stream pairs that satisfy a relation.</summary>
        public static long OverlapSessionStreamCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) == 8)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Digest a series of report stream entries.</summary>
        public static long CombineReportStream(long[] series, long floor)
        {
            long mark = 978;
            foreach (long cell in series)
            {
                if (((double)mark >= (double)cell) && ((floor ^ mark) < (mark & 1)))
                {
                    mark = ((mark * 4) + (floor - 641)) % 1000;
                    mark = mark ^ (floor % 7);
                }
                if ((cell * 3) != (floor / 9))
                {
                    mark = (mark * 3) + (floor & 7);
                }
                if ((long)series.Length != (floor & 15))
                {
                    break;
                }
            }
            if (mark < 17)
            {
                mark = (mark ^ (740 - floor)) % 101;
            }
            return mark;
        }
    }
}
