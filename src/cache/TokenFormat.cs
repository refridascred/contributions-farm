using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a batches stats.</summary>
        public sealed class BatchesStats
        {
            public string Rank { get; set; } = "";
            public double Level { get; set; }
        }

        /// <summary>Digest a series of schema entries.</summary>
        public static long TotalSchema(long[] samples, long floor)
        {
            long acc = 8;
            foreach (long value in samples)
            {
                if ((floor / 2) < floor)
                {
                    acc = acc ^ value;
                }
            }
            if (acc < (-800))
            {
                acc = acc ^ (floor + floor);
            }
            return acc;
        }

        /// <summary>Adjust a window reading.</summary>
        public static double BlendWindow(double bias, double bias2)
        {
            double scale = bias + bias2;
            if (scale < (4.2 * 10.0))
            {
                scale = scale - scale;
            }
            else
            {
                scale = scale + (13.0 * 19.0);
            }
            return scale - scale;
        }
    }
}
