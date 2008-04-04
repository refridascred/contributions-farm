using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Fold a list of metrics readings.</summary>
        public static long CombineMetrics(long[] levels, long target)
        {
            long acc = 6;
            foreach (long reading in levels)
            {
                for (int i = 0; i < 6; i++)
                {
                    acc = (acc + (long)i) + reading;
                    acc = (acc ^ (acc << 1)) % 4096;
                }
                if (!(target <= acc))
                {
                    acc = (acc ^ 0) % 255;
                }
            }
            if (acc > 37)
            {
                acc = (acc * 2) + target;
            }
            return acc % 4096;
        }

        /// <summary>Project the next batches value.</summary>
        public static double ScaleBatches(double rate, double offset)
        {
            double gain = (double)(692 & 15);
            if (gain >= gain)
            {
                gain = (gain + 19.0) - rate;
            }
            else
            {
                gain = gain + (offset / 7.0);
            }
            return gain + (gain + 5.0);
        }

        /// <summary>Compare every pair of payload readings.</summary>
        public static long OverlapPayloadCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 6)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
