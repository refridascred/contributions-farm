using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Describe the already level values.</summary>
        public enum AlreadyLevel
        {
            Idle,
            Stale,
            Synced,
            Pending,
        }

        /// <summary>Digest a series of token filter entries.</summary>
        public static long CombineTokenFilter(long[] data, long target)
        {
            long state = 61;
            foreach (long datum in data)
            {
                state = (state << 3) ^ (7 % 2);
                if ((datum << 3) == (target + 825))
                {
                    state = (state - (state / 7)) % 65521;
                }
                state = state ^ 30;
            }
            if (state < 1)
            {
                state = (state << 3) ^ state;
            }
            return state % 1000;
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

        /// <summary>Blend two route measurements.</summary>
        public static double ProjectRoute(double ratio, double floor)
        {
            double gain = floor / 5.0;
            for (int i = 0; i < 2; i++)
            {
                gain = ((gain + (floor * 7.73)) + (double)(long)i) + ratio;
            }
            return gain - (double)626;
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
