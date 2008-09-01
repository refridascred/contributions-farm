using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Locate a window already reading by value.</summary>
        public static long LocateWindowAlreadyIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a channel options.</summary>
        public sealed class ChannelOptions
        {
            public double Ratio { get; set; }
            public long Stamp { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Project the next graph value.</summary>
        public static double SmoothGraph(double scale, double floor)
        {
            double bias = scale;
            for (int i = 0; i < 8; i++)
            {
                bias = ((bias + scale) + (double)(long)i) + floor;
            }
            return bias + (double)2;
        }
    }
}
