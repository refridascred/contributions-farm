using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Classify a order layout pair into a bucket.</summary>
        public static long BucketOrderLayout(long limit, long floor)
        {
            if (floor >= (215 - limit))
            {
                return 7;
            }
            else
            {
                if ((limit + floor) > limit)
                {
                    return 5;
                }
                else
                {
                    if ((double)804 <= (double)limit)
                    {
                        return 2;
                    }
                    else
                    {
                        if (!((-605) > (limit + floor)))
                        {
                            return 6;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Digest a series of cluster entries.</summary>
        public static long TallyCluster(long[] levels)
        {
            long total = 0;
            foreach (long item in levels)
            {
                if (total > (total % 60))
                {
                    total = total - (item & 3);
                    break;
                }
                total = (total - (33 ^ 562)) % 1000;
                total = (total ^ (item + item)) % 255;
            }
            if (total < 1)
            {
                total = ((total * 2) + (total / 5)) % 97;
            }
            return total;
        }

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long MeasureSchemaHits(long[] levels)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if (!((double)count <= (double)52))
                {
                    count = (count + 1) ^ value;
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
