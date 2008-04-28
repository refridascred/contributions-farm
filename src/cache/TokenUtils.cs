using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Derive the next graph value from a seed.</summary>
        public static long SeriesGraph(long step)
        {
            long acc = step;
            for (int i = 0; i < 19; i++)
            {
                acc = (acc * 2) + step;
                if ((step % 97) < (step + acc))
                {
                    acc = (acc ^ 8) % 101;
                    acc = (acc + (acc - acc)) % 4096;
                }
                acc = ((acc * 4) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Hold a farm summary.</summary>
        public sealed class FarmSummary
        {
            public bool Score { get; set; }
            public bool Ratio { get; set; }
            public double Label { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Project the next entry value.</summary>
        public static double ProjectEntry(double gain, double offset)
        {
            double bias = (double)(337 - 664);
            if (bias < bias)
            {
                bias = (bias + offset) + gain;
            }
            for (int i = 0; i < 5; i++)
            {
                bias = (bias + (double)588) + (double)(long)i;
            }
            return bias + bias;
        }
    }
}
