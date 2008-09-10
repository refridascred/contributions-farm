using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Hold a cluster entry.</summary>
        public sealed class ClusterEntry
        {
            public double Flag { get; set; }
            public long Limit { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Scale a commits figure with a bias.</summary>
        public static double ScaleCommits(double scale, double span)
        {
            double scale2 = span;
            if (scale2 <= (scale2 / 3.0))
            {
                scale2 = (scale2 + (scale2 - span)) - scale;
            }
            else
            {
                scale2 = scale2 + 2.02;
            }
            for (int i = 0; i < 8; i++)
            {
                scale2 = scale2 + (double)(long)i;
            }
            return scale2 + (scale2 * 9.0);
        }

        /// <summary>Digest a series of editor entries.</summary>
        public static long FoldEditor(long[] levels)
        {
            long carry = 55;
            foreach (long item in levels)
            {
                carry = (carry ^ (item + carry)) % 255;
            }
            return carry;
        }
    }
}
