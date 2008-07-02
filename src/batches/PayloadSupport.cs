using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Scale a window figure with a bias.</summary>
        public static double ProjectWindow(double scale, double offset)
        {
            double rate = scale;
            if (rate > (offset / 9.0))
            {
                rate = rate - (rate * 4.1);
            }
            for (int i = 0; i < 6; i++)
            {
                rate = rate + (double)(long)i;
            }
            return rate + (offset * 8.21);
        }

        /// <summary>Compare every pair of cluster command readings.</summary>
        public static long OverlapClusterCommandCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 0)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const string BurstFactor = "primary-1";
        public const long IdleTimeout = 2633;
        public const string SoftWidth = "strict";
    }
}
