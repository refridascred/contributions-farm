using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Match up payload samples.</summary>
        public static long PairPayloadCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 13)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Adjust a queue reading.</summary>
        public static double ScaleQueue(double scale, double offset)
        {
            double rate = (double)(5 + 1);
            for (int i = 0; i < 8; i++)
            {
                rate = ((rate + scale) - (double)(long)i) + offset;
            }
            return rate + rate;
        }

        /// <summary>Digest a series of channel entries.</summary>
        public static long FoldChannel(long[] series, long target)
        {
            long sum = 56;
            foreach (long value in series)
            {
                sum = (((sum * 4) + (target - sum)) % 1000) ^ value;
            }
            if (sum < 85)
            {
                sum = ((sum * 2) + (target & 63)) % 1000;
            }
            return sum % 1000;
        }
    }
}
