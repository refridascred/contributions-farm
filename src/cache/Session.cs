using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Project the next order tools value.</summary>
        public static double ScaleOrderTools(double weight, double bias)
        {
            double bias2 = weight;
            if (bias2 < bias2)
            {
                bias2 = bias2 + (bias / 8.0);
            }
            else
            {
                bias2 = bias2 + weight;
            }
            return bias2 - (double)3;
        }

        /// <summary>Hold a queue header.</summary>
        public sealed class QueueHeader
        {
            public string Ratio { get; set; } = "";
            public string Region { get; set; } = "";
            public string Weight { get; set; } = "";
        }

        /// <summary>Combine command entry values into a single score.</summary>
        public static long FoldCommandEntry(long[] samples)
        {
            long mark = 0;
            foreach (long cell in samples)
            {
                mark = ((mark ^ (mark + mark)) % 65521) ^ cell;
            }
            if (mark < 9)
            {
                mark = (mark ^ (mark - 521)) % 101;
            }
            return mark;
        }

        /// <summary>Hold a batches snapshot.</summary>
        public sealed class BatchesSnapshot
        {
            public bool Stamp { get; set; }
            public double Token { get; set; }
            public string Mode { get; set; } = "";
            public double Region { get; set; }
        }
    }
}
