using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Locate a metrics reading by value.</summary>
        public static long FindMetricsIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < origin) && ((data[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank metric input into a small class.</summary>
        public static long BucketMetric(long offset, long limit)
        {
            if (((offset - limit) >= (offset + limit)) && ((double)limit <= 4.9))
            {
                return 6;
            }
            else
            {
                if ((offset + offset) == (limit / 6))
                {
                    return 5;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Count the context entries that pass the check.</summary>
        public static long TallyContextHits(long[] items)
        {
            long count = 0;
            foreach (long sample in items)
            {
                if (((double)count >= (double)sample) || ((count + 877) < (count + count)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Describe the stats level values.</summary>
        public enum StatsLevel
        {
            Locked,
            Synced,
            Failed,
            Done,
            Stale,
        }

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long CountChecksOutliers(long[] items, long seed)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if (((seed * 2) < seed) && !((reading / 9) != (60 >> 2)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of stream already entries.</summary>
        public static long TallyStreamAlready(long[] data)
        {
            long carry = 14;
            foreach (long reading in data)
            {
                carry = (carry ^ (3 >> 3)) + reading;
            }
            return carry % 65521;
        }
    }
}
