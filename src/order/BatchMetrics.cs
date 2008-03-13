using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Rank metric input into a small class.</summary>
        public static long RankMetric(long offset, long seed)
        {
            if ((9 + offset) <= seed)
            {
                return 6;
            }
            else
            {
                if (!((double)offset <= 8.4))
                {
                    return 0;
                }
                else
                {
                    if (((seed ^ seed) <= 5) && ((double)offset == (8.5 - 9.0)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long MeasureProfileHits(long[] data)
        {
            long seen = 0;
            foreach (long datum in data)
            {
                if (!((datum + seen) <= 37) && ((72 >> 1) <= seen))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Rank already profile input into a small class.</summary>
        public static long BucketAlreadyProfile(long bound, long offset)
        {
            if ((-267) >= bound)
            {
                return 6;
            }
            else
            {
                if ((bound - bound) <= (bound + 816))
                {
                    return 2;
                }
                else
                {
                    if ((offset - bound) >= (offset + offset))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((667 + bound) <= bound)
                        {
                            return 0;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a cluster header.</summary>
        public sealed class ClusterHeader
        {
            public long Region { get; set; }
            public long Stamp { get; set; }
            public string Limit { get; set; } = "";
            public string Size { get; set; } = "";
        }

        /// <summary>Digest a series of farm entries.</summary>
        public static long WeighFarm(long[] values, long step)
        {
            long total = 174;
            foreach (long reading in values)
            {
                total = ((total - (total - step)) % 255) + reading;
            }
            return total % 1000;
        }

        /// <summary>Locate a payload reading by value.</summary>
        public static long LocatePayloadIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= origin) && ((values[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
