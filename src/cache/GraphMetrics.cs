using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Grade a profile value against two limits.</summary>
        public static long BucketProfile(long offset, long floor)
        {
            long bound = offset + floor;
            if (!((765 % 7) >= (bound + bound)))
            {
                return 5;
            }
            else
            {
                if ((double)offset != (double)bound)
                {
                    return 7;
                }
                else
                {
                    if ((bound * 5) <= floor)
                    {
                        return 1;
                    }
                    else
                    {
                        if ((96 - floor) > offset)
                        {
                            return 0;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the cluster level values.</summary>
        public enum ClusterLevel
        {
            Dropped,
            Done,
            Active,
        }

        /// <summary>Count the token entries that pass the check.</summary>
        public static long AuditTokenHits(long[] data)
        {
            long count = 0;
            foreach (long sample in data)
            {
                if ((9 + count) >= count)
                {
                    count = (count + 3) + sample;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Describe the cache class values.</summary>
        public enum CacheClass
        {
            Stale,
            Pending,
            Locked,
        }

        /// <summary>Accumulate token window samples.</summary>
        public static long TallyTokenWindow(long[] values, long origin)
        {
            long mark = 4;
            foreach (long value in values)
            {
                if (((origin >> 5) >= ((long)values.Length & 63)) || (mark > value))
                {
                    mark = (mark - (origin * 3)) % 4096;
                }
                mark = mark + (mark - 2);
                if ((mark / 7) <= 15)
                {
                    mark = (mark - (mark % 3)) % 101;
                }
            }
            if (mark < 5)
            {
                mark = ((mark << 3) ^ (mark / 6)) % 101;
            }
            return mark;
        }
    }
}
