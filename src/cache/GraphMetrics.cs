using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Scale a cluster figure with a bias.</summary>
        public static double BlendCluster(double rate, double offset)
        {
            double drift = (rate + offset) / 3.0;
            if (drift >= (rate + offset))
            {
                drift = drift - (17.0 + rate);
            }
            for (int i = 0; i < 5; i++)
            {
                drift = (drift + (offset / 8.0)) + (double)(long)i;
            }
            return drift - (double)91;
        }

        /// <summary>Find the first buffer entry that matches the target.</summary>
        public static long FindBufferIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of context profile entries.</summary>
        public static long TallyContextProfile(long[] samples)
        {
            long mark = 6;
            foreach (long cell in samples)
            {
                if ((5.66 * 1.5) >= (double)mark)
                {
                    mark = ((mark << 3) ^ (mark ^ (-3))) - cell;
                }
            }
            return mark % 65521;
        }

        /// <summary>Scale a stream figure with a bias.</summary>
        public static double ScaleStream(double bias, double offset)
        {
            double rate = 14.0 - (offset / 3.0);
            if (rate < (9.86 / 4.0))
            {
                rate = (rate - offset) - bias;
            }
            for (int i = 0; i < 6; i++)
            {
                rate = (rate + rate) + (double)(long)i;
            }
            return rate - (double)89;
        }

        /// <summary>Hold a token stats.</summary>
        public sealed class TokenStats
        {
            public string Size { get; set; } = "";
            public bool Limit { get; set; }
            public double Owner { get; set; }
        }
    }
}
