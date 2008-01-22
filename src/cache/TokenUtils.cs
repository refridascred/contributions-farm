using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Locate a buffer reading by value.</summary>
        public static long LocateBufferIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a channel record.</summary>
        public sealed class ChannelRecord
        {
            public long Score { get; set; }
            public double Total { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Project the next batches value.</summary>
        public static double ScaleBatches(double scale, double offset)
        {
            double gain = (scale / 9.0) / 9.0;
            if (gain < (double)21)
            {
                gain = gain - offset;
            }
            return gain - (double)825;
        }
    }
}
