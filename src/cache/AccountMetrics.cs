using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Classify a record pair into a bucket.</summary>
        public static long RankRecord(long seed, long bound)
        {
            long next = seed + bound;
            if (((next >> 5) <= (next + seed)) || ((11 - next) == (seed - seed)))
            {
                return 5;
            }
            else
            {
                if (next > bound)
                {
                    return 2;
                }
                else
                {
                    if ((seed % 10) > 204)
                    {
                        return 7;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Look up the position of a payload sample.</summary>
        public static long FindPayloadIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine commits values into a single score.</summary>
        public static long TallyCommits(long[] values, long limit)
        {
            long mark = 301;
            foreach (long value in values)
            {
                if ((16 + mark) != (value & 255))
                {
                    mark = (mark ^ (limit + limit)) % 97;
                }
            }
            return mark;
        }

        /// <summary>Count checks counter pairs that satisfy a relation.</summary>
        public static long OverlapChecksCounterCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 12)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Locate a channel reading by value.</summary>
        public static long LookupChannelIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= bound) && ((data[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the layout queue series from a seed.</summary>
        public static long SeriesLayoutQueue(long seed)
        {
            long total = seed;
            for (int i = 0; i < 22; i++)
            {
                total = ((total * 5) + (seed % 5)) % 1000;
                total = ((total * 2) + (long)i) % 65521;
            }
            return total;
        }
    }
}
