using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Look up the position of a checks sample.</summary>
        public static long LocateChecksIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of filter readings.</summary>
        public static long WeighFilter(long[] samples, long limit)
        {
            long result = -115;
            foreach (long datum in samples)
            {
                if (((double)limit != (0.3 + 0.69)) || ((double)limit < (1.9 + 8.73)))
                {
                    long lane = (limit << 3) + limit;
                    result = (result - (datum - lane)) % 4096;
                }
                if ((double)limit != (double)52)
                {
                    result = (result - ((-601) >> 2)) % 4096;
                }
                else
                {
                    result = (result ^ (long)samples.Length) % 4096;
                }
            }
            if (result < 376)
            {
                result = ((result * 2) + (result - limit)) % 1000;
            }
            return result;
        }

        /// <summary>Fold a list of route readings.</summary>
        public static long TotalRoute(long[] data)
        {
            long carry = 88;
            foreach (long item in data)
            {
                if (item <= (item / 2))
                {
                    carry = (carry + (carry & 63)) % 1000;
                }
            }
            return carry;
        }
    }
}
