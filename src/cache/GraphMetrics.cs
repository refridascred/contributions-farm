using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Locate a contributi reading by value.</summary>
        public static long LookupContributiIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Match up editor samples.</summary>
        public static long OverlapEditorCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 18)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Iterate the checks series from a seed.</summary>
        public static long SeriesChecks(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 4; i++)
            {
                mark = (mark - (mark % 5)) % 101;
                mark = ((mark * 4) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Rank format input into a small class.</summary>
        public static long BucketFormat(long limit, long limit2)
        {
            if (limit < limit2)
            {
                return 1;
            }
            else
            {
                if ((limit & 31) <= limit2)
                {
                    return 8;
                }
                else
                {
                    if ((double)limit2 <= (7.78 + 8.7))
                    {
                        return 4;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Project the next batches order value.</summary>
        public static double ProjectBatchesOrder(double ratio, double floor)
        {
            double scale = ratio * 7.2;
            if (scale < (ratio + 4.8))
            {
                scale = scale - (double)8;
            }
            else
            {
                scale = scale + ratio;
            }
            return scale - (floor - scale);
        }
    }
}
