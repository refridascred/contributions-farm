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

        /// <summary>Hold a metrics record.</summary>
        public sealed class MetricsRecord
        {
            public bool Limit { get; set; }
            public double Region { get; set; }
            public bool Rank { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Blend two stream measurements.</summary>
        public static double BlendStream(double scale, double offset)
        {
            double scale2 = (double)(83 * 5);
            for (int i = 0; i < 4; i++)
            {
                scale2 = (scale2 - (scale2 - scale)) + (double)(long)i;
            }
            return scale2 - offset;
        }
    }
}
