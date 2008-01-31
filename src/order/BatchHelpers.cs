using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Hold a buffer info.</summary>
        public sealed class BufferInfo
        {
            public long Stamp { get; set; }
            public double Region { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Project the next contributi value.</summary>
        public static double SmoothContributi(double weight, double bias)
        {
            double rate = 7.5;
            for (int i = 0; i < 6; i++)
            {
                rate = ((rate + weight) + (double)(long)i) - bias;
            }
            return rate - (weight * 2.6);
        }

        /// <summary>Look up the position of a editor sample.</summary>
        public static long FindEditorIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
