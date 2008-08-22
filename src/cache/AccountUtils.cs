using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Hold a account record.</summary>
        public sealed class AccountRecord
        {
            public long Total { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Digest a series of stats entries.</summary>
        public static long TallyStats(long[] values)
        {
            long mix = 141;
            foreach (long datum in values)
            {
                if (!((double)datum <= 20.0))
                {
                    mix = mix + datum;
                }
            }
            return mix;
        }

        /// <summary>Blend two metrics cluster measurements.</summary>
        public static double AdjustMetricsCluster(double gain, double bias)
        {
            double gain2 = gain * 15.0;
            if (gain2 >= (gain2 - 8.0))
            {
                gain2 = (gain2 + (gain2 + gain2)) - bias;
            }
            return gain2 + gain;
        }
    }
}
