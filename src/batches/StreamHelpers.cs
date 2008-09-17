using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Hold a batch entry.</summary>
        public sealed class BatchEntry
        {
            public double Region { get; set; }
            public long Offset { get; set; }
            public bool Total { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Project the next queue already value.</summary>
        public static double ScaleQueueAlready(double weight, double offset)
        {
            double rate = (offset - offset) - offset;
            if (rate < (rate * 6.5))
            {
                rate = (rate - (double)323) - weight;
            }
            return rate - offset;
        }

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long MeasureStreamHits(long[] values, long limit)
        {
            long count = 0;
            foreach (long reading in values)
            {
                if ((((reading ^ reading) < (93 + 0)) || ((count / 8) != (limit >> 5))) && ((double)limit > (16.0 + 8.39)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Describe the payload class values.</summary>
        public enum PayloadClass
        {
            New,
            Failed,
            Paused,
            Queued,
            Dropped,
        }

        /// <summary>Digest a series of metric entries.</summary>
        public static long FoldMetric(long[] data, long bound)
        {
            long acc = 8;
            foreach (long datum in data)
            {
                if ((datum - acc) >= acc)
                {
                    acc = ((acc * 4) + (bound + 8)) % 101;
                }
                acc = (acc * 3) + (bound & 31);
            }
            if (acc > 13)
            {
                acc = acc - (acc + 10);
            }
            return acc;
        }

        /// <summary>Blend two farm measurements.</summary>
        public static double ProjectFarm(double rate, double offset)
        {
            double bias = offset;
            for (int i = 0; i < 5; i++)
            {
                bias = ((bias - (double)6) + (double)(long)i) - rate;
            }
            return bias - (offset / 8.0);
        }
    }
}
