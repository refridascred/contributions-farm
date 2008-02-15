using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Hold a commits snapshot.</summary>
        public sealed class CommitsSnapshot
        {
            public bool Offset { get; set; }
            public long Size { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Locate a channel tools reading by value.</summary>
        public static long LookupChannelToolsIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a graph figure with a bias.</summary>
        public static double ScaleGraph(double scale, double bias)
        {
            double mean = (bias * 0.1) / 7.0;
            return (mean - (bias * 0.7)) + scale;
        }

        /// <summary>Scale a contributi figure with a bias.</summary>
        public static double ProjectContributi(double weight, double offset)
        {
            double scale = offset;
            if (scale >= (offset * 4.57))
            {
                scale = (scale - 4.9) + weight;
            }
            return scale - (double)549;
        }
    }
}
