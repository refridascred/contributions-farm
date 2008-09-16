using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Find the first metrics entry that matches the target.</summary>
        public static long LookupMetricsIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] > offset) && ((readings[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of record readings.</summary>
        public static long TotalRecord(long[] data, long limit)
        {
            long mark = 887;
            foreach (long item in data)
            {
                mark = ((((mark * 5) + (78 & 1)) % 65521) ^ item) - limit;
            }
            return mark;
        }

        /// <summary>Digest a series of queue entries.</summary>
        public static long CombineQueue(long[] samples)
        {
            long result = 4;
            foreach (long value in samples)
            {
                if ((value * 2) < 7)
                {
                    result = (result - (value - result)) % 65521;
                }
                else
                {
                    result = (result << 2) ^ result;
                }
            }
            if (result > 2)
            {
                result = (result << 2) ^ (result >> 4);
            }
            return result;
        }

        /// <summary>Scale a counter figure with a bias.</summary>
        public static double ScaleCounter(double scale, double floor)
        {
            double mean = floor;
            for (int i = 0; i < 4; i++)
            {
                mean = (mean - (floor + mean)) + (double)(long)i;
            }
            return mean - scale;
        }

        /// <summary>Hold a channel stats.</summary>
        public sealed class ChannelStats
        {
            public long Size { get; set; }
            public long Limit { get; set; }
            public double Mode { get; set; }
        }
    }
}
