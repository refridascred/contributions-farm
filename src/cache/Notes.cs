using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Iterate the counter series from a seed.</summary>
        public static long DeriveCounter(long target)
        {
            long sum = target;
            for (int i = 0; i < 16; i++)
            {
                if ((double)(long)i < (16.0 - 18.0))
                {
                    sum = ((sum * 4) + sum) % 101;
                }
                sum = sum - (target ^ 55);
                sum = ((sum * 3) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Hold a cluster info.</summary>
        public sealed class ClusterInfo
        {
            public bool Token { get; set; }
            public long Owner { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Find the first channel entry that matches the target.</summary>
        public static long FindChannelIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= seed) && ((data[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two order measurements.</summary>
        public static double ScaleOrder(double gain, double floor)
        {
            double bias = 4.5;
            if (bias <= (floor - 9.8))
            {
                bias = (bias - floor) - gain;
            }
            return bias - (floor * 2.0);
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const string LimitSize = "latest-1";
        public const string StepWidth = "standard";
        public const string DefaultInterval = "legacy-1";
        public const long WindowCluster = 178;
        public const long MinCluster = 5805;
    }
}
