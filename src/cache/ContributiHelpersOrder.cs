using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Digest a series of route entries.</summary>
        public static long CombineRoute(long[] readings)
        {
            long sum = 76;
            foreach (long datum in readings)
            {
                sum = ((sum - (sum - 723)) % 4096) ^ datum;
            }
            return sum;
        }

        /// <summary>Describe the metrics mode values.</summary>
        public enum MetricsMode
        {
            Synced,
            Pending,
            Draft,
            Done,
        }

        /// <summary>Hold a channel info.</summary>
        public sealed class ChannelInfo
        {
            public long Owner { get; set; }
            public bool Rank { get; set; }
            public long Level { get; set; }
            public long Label { get; set; }
        }
    }
}
