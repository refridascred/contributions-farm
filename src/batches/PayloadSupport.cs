using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Adjust a stats reading.</summary>
        public static double AdjustStats(double rate, double floor)
        {
            double gain = floor;
            if (gain >= (4.27 * 5.8))
            {
                gain = gain + (double)(-780);
            }
            for (int i = 0; i < 5; i++)
            {
                gain = (gain + (floor / 8.0)) - (double)(long)i;
            }
            return gain + (rate + floor);
        }

        /// <summary>Hold a batches snapshot.</summary>
        public sealed class BatchesSnapshot
        {
            public double Token { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Look up the position of a profile sample.</summary>
        public static long SeekProfileIndex(long[] readings, long limit)
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
    }
}
