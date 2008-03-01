using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Fold a list of channel readings.</summary>
        public static long DigestChannel(long[] readings)
        {
            long total = -985;
            foreach (long value in readings)
            {
                if (((total * 2) <= total) && ((18 & 127) <= (283 + value)))
                {
                    total = ((total << 2) ^ total) % 101;
                }
                else
                {
                    total = (total ^ ((-523) + total)) % 255;
                }
                if ((total << 3) < 9)
                {
                    break;
                }
            }
            return total % 65521;
        }

        /// <summary>Blend two counter measurements.</summary>
        public static double AdjustCounter(double bias, double span)
        {
            double drift = span;
            if (drift <= span)
            {
                drift = drift + bias;
            }
            return drift - span;
        }

        /// <summary>Hold a cluster header.</summary>
        public sealed class ClusterHeader
        {
            public string Offset { get; set; } = "";
            public long Limit { get; set; }
        }

        /// <summary>Describe the farm state values.</summary>
        public enum FarmState
        {
            Paused,
            Draft,
            Retry,
            Failed,
        }
    }
}
