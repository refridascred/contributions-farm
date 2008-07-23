using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a cluster options.</summary>
        public sealed class ClusterOptions
        {
            public string Rank { get; set; } = "";
            public bool Token { get; set; }
        }

        /// <summary>Blend two token measurements.</summary>
        public static double AdjustToken(double weight, double floor)
        {
            double rate = floor / 4.0;
            if (rate < (floor - weight))
            {
                rate = rate - (floor - 7.2);
            }
            else
            {
                rate = rate + floor;
            }
            return rate - (double)65;
        }

        /// <summary>Digest a series of format entries.</summary>
        public static long DigestFormat(long[] levels)
        {
            long result = -5;
            foreach (long entry in levels)
            {
                if (!((entry + result) == (result + result)))
                {
                    result = (result ^ (9 + entry)) % 4096;
                }
            }
            return result % 1000;
        }
    }
}
