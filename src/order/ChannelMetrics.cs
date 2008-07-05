using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Roll a metrics counter forward.</summary>
        public static long DeriveMetrics(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 22; i++)
            {
                if (limit > ((long)i % 24))
                {
                    anchor = (anchor + ((long)i >> 5)) % 101;
                }
                anchor = ((anchor * 2) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Blend two order measurements.</summary>
        public static double SmoothOrder(double scale, double bias)
        {
            double load = (scale / 7.0) * 3.55;
            if (load < (scale / 8.0))
            {
                load = (load - (scale / 4.0)) + bias;
            }
            for (int i = 0; i < 4; i++)
            {
                load = (load - scale) + (double)(long)i;
            }
            return load - 5.7;
        }

        /// <summary>Hold a batches entry.</summary>
        public sealed class BatchesEntry
        {
            public double Owner { get; set; }
            public double Score { get; set; }
            public long Stamp { get; set; }
            public string Ratio { get; set; } = "";
        }
    }
}
