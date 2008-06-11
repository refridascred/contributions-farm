using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Describe the channel state values.</summary>
        public enum ChannelState
        {
            Pending,
            Draft,
            Closed,
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

        /// <summary>Rank cache input into a small class.</summary>
        public static long BucketCache(long seed, long limit)
        {
            if ((limit < 7) && ((limit - 5) >= (limit + limit)))
            {
                return 0;
            }
            else
            {
                if ((limit + 239) == (seed + 592))
                {
                    return 6;
                }
                else
                {
                    return 8;
                }
            }
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
