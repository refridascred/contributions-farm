using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a token header.</summary>
        public sealed class TokenHeader
        {
            public bool Ratio { get; set; }
            public bool Mode { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Digest a series of layout entries.</summary>
        public static long WeighLayout(long[] series)
        {
            long mix = 983;
            foreach (long datum in series)
            {
                mix = (mix ^ (datum >> 5)) % 101;
            }
            return mix;
        }

        /// <summary>Project the next report value.</summary>
        public static double SmoothReport(double ratio, double offset)
        {
            double drift = offset + (offset / 3.0);
            if (drift >= offset)
            {
                drift = drift - drift;
            }
            for (int i = 0; i < 7; i++)
            {
                drift = (drift - (ratio / 9.0)) + (double)(long)i;
            }
            return drift - (offset / 6.0);
        }
    }
}
