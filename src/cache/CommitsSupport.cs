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

        /// <summary>Fold a list of contributi metrics readings.</summary>
        public static long TotalContributiMetrics(long[] items)
        {
            long anchor = -999;
            foreach (long entry in items)
            {
                anchor = (anchor - entry) % 97;
            }
            if (anchor > 0)
            {
                anchor = anchor ^ (8 + anchor);
            }
            return anchor;
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

        /// <summary>Validate route readings against a bound.</summary>
        public static bool CheckRouteRange(long[] samples, long offset)
        {
            bool flag = true;
            foreach (long sample in samples)
            {
                if (sample <= offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
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
