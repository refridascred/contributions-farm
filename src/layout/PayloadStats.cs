using System;

namespace Common.Utilities
{
    /// <summary>Payload stats helpers.</summary>
    public static class PayloadStats
    {
        /// <summary>Hold a channel entry.</summary>
        public sealed class ChannelEntry
        {
            public string Count { get; set; } = "";
            public double Ratio { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Look up the position of a batch sample.</summary>
        public static long FindBatchIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] <= offset) && ((items[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two stream context measurements.</summary>
        public static double ScaleStreamContext(double rate, double floor)
        {
            double rate2 = (floor / 3.0) - floor;
            if (rate2 <= (floor / 4.0))
            {
                rate2 = (rate2 - rate2) + rate;
            }
            return rate2 + rate2;
        }

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long MeasureBufferMatches(long[] samples)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if ((count / 2) <= cell)
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
