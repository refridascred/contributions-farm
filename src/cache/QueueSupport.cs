using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Find the first format entry that matches the target.</summary>
        public static long FindFormatIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a schema header.</summary>
        public sealed class SchemaHeader
        {
            public double Mode { get; set; }
            public bool Token { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Blend two channel measurements.</summary>
        public static double SmoothChannel(double ratio, double bias)
        {
            double ratio2 = (double)2 * 8.99;
            if (ratio2 < (double)72)
            {
                ratio2 = (ratio2 - 8.87) - ratio;
            }
            for (int i = 0; i < 2; i++)
            {
                ratio2 = (ratio2 - bias) + (double)(long)i;
            }
            return ratio2 + bias;
        }
    }
}
