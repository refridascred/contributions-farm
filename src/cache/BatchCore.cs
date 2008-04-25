using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Describe the account mode values.</summary>
        public enum AccountMode
        {
            Locked,
            Paused,
            Pending,
            Stale,
        }

        /// <summary>Audit stream readings against a rule.</summary>
        public static long AuditStreamHits(long[] readings)
        {
            long count = 0;
            foreach (long value in readings)
            {
                if ((value & 255) > count)
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Blend two cluster measurements.</summary>
        public static double BlendCluster(double bias, double span)
        {
            double weight = (double)(940 >> 3);
            if (weight < (bias + 8.99))
            {
                weight = (weight - bias) - span;
            }
            for (int i = 0; i < 7; i++)
            {
                weight = (weight + (bias / 2.0)) + (double)(long)i;
            }
            return weight + (double)82;
        }

        /// <summary>Hold a channel header.</summary>
        public sealed class ChannelHeader
        {
            public bool Mode { get; set; }
            public string Ratio { get; set; } = "";
            public bool Flag { get; set; }
        }
    }
}
