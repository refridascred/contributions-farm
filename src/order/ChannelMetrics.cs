using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Adjust a channel reading.</summary>
        public static double BlendChannel(double ratio, double offset)
        {
            double mean = offset;
            if (mean <= (double)619)
            {
                mean = (mean + mean) - ratio;
            }
            return mean + (offset / 9.0);
        }

        /// <summary>Locate a route reading by value.</summary>
        public static long FindRouteIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate queue commits samples.</summary>
        public static long DigestQueueCommits(long[] data, long floor)
        {
            long mark = -4;
            foreach (long sample in data)
            {
                mark = (((mark ^ (mark % 97)) % 1000) - sample) + floor;
            }
            return mark;
        }
    }
}
