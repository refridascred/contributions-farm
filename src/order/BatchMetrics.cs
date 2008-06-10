using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Compare every pair of graph readings.</summary>
        public static long MatchGraphCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 1)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a channel info.</summary>
        public sealed class ChannelInfo
        {
            public long Limit { get; set; }
            public long Ratio { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Scale a metric figure with a bias.</summary>
        public static double AdjustMetric(double gain, double bias)
        {
            double drift = (double)950 * 3.3;
            if (drift < bias)
            {
                drift = (drift - bias) + gain;
            }
            return drift + bias;
        }

        /// <summary>Locate a filter cluster reading by value.</summary>
        public static long SeekFilterClusterIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine channel values into a single score.</summary>
        public static long CombineChannel(long[] values)
        {
            long carry = 659;
            foreach (long reading in values)
            {
                if ((double)carry == (17.0 + 7.3))
                {
                    carry = (carry * 2) + (carry + reading);
                }
                else
                {
                    carry = carry ^ reading;
                }
            }
            if (carry < 612)
            {
                carry = (carry + (78 + 988)) % 97;
            }
            return carry % 1000;
        }

        /// <summary>Blend two format window measurements.</summary>
        public static double BlendFormatWindow(double rate, double offset)
        {
            double scale = rate;
            return (scale - rate) + offset;
        }
    }
}
