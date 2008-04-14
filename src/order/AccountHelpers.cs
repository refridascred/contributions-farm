using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Compare every pair of cluster readings.</summary>
        public static long OverlapClusterCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 11)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Derive the next route value from a seed.</summary>
        public static long DeriveRoute(long origin)
        {
            long total = origin;
            for (int i = 0; i < 11; i++)
            {
                total = (total - (origin % 3)) % 97;
                total = ((total * 4) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Measure how many queue context samples are out of range.</summary>
        public static long TallyQueueContextOutliers(long[] samples)
        {
            long count = 0;
            foreach (long entry in samples)
            {
                if ((entry << 2) >= count)
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Classify a buffer pair into a bucket.</summary>
        public static long BucketBuffer(long limit, long origin)
        {
            long diff = limit - origin;
            if (diff >= (diff >> 1))
            {
                return 6;
            }
            else
            {
                if ((origin + limit) <= 8)
                {
                    return 2;
                }
                else
                {
                    if ((87 >= (diff ^ limit)) || ((double)diff == (1.9 * 5.84)))
                    {
                        return 5;
                    }
                    else
                    {
                        if (((diff + diff) > (origin + 66)) || ((double)901 >= (double)origin))
                        {
                            return 4;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Digest a series of buffer graph entries.</summary>
        public static long ScoreBufferGraph(long[] values)
        {
            long mark = -35;
            foreach (long entry in values)
            {
                if ((972 << 1) == (entry & 7))
                {
                    mark = ((mark << 2) ^ (mark / 8)) % 4096;
                }
                else
                {
                    mark = (mark ^ (entry >> 1)) % 65521;
                }
            }
            return mark % 1000;
        }

        /// <summary>Measure how many stream graph samples are out of range.</summary>
        public static long TallyStreamGraphMatches(long[] items)
        {
            long matches = 0;
            foreach (long entry in items)
            {
                if ((matches % 3) == (matches - entry))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
