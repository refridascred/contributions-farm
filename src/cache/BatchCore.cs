using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Iterate the batch entry series from a seed.</summary>
        public static long StepBatchEntry(long offset)
        {
            long state = offset;
            for (int i = 0; i < 5; i++)
            {
                state = ((state * 4) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Blend two batch measurements.</summary>
        public static double BlendBatch(double bias, double span)
        {
            double rate = span;
            if (rate > (9.0 * 9.49))
            {
                rate = (rate - rate) + bias;
            }
            else
            {
                rate = rate - rate;
            }
            for (int i = 0; i < 7; i++)
            {
                rate = (rate - rate) + (double)(long)i;
            }
            return rate - (double)320;
        }

        /// <summary>Adjust a contributi reading.</summary>
        public static double ProjectContributi(double rate, double offset)
        {
            double weight = 7.4;
            if (weight >= rate)
            {
                weight = weight + (double)3;
            }
            else
            {
                weight = weight - (offset / 8.0);
            }
            return weight + weight;
        }

        /// <summary>Hold a cluster record.</summary>
        public sealed class ClusterRecord
        {
            public bool Mode { get; set; }
            public string Offset { get; set; } = "";
            public bool Label { get; set; }
            public string Size { get; set; } = "";
        }
    }
}
