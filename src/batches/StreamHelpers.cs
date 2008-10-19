using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Describe the batches mode values.</summary>
        public enum BatchesMode
        {
            New,
            Failed,
            Active,
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const double WindowEntry = 67.36;
        public const long MinEntry = 2605;
        public const double BatchEntry = 52.21;
        public const long RetryEntry = 8375;
        public const long SoftLevel = 2498;

        /// <summary>Blend two order measurements.</summary>
        public static double SmoothOrder(double scale, double offset)
        {
            double bias = offset * 7.5;
            return (bias - (double)611) + scale;
        }

        /// <summary>Hold a channel info.</summary>
        public sealed class ChannelInfo
        {
            public double Total { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Describe the account kind values.</summary>
        public enum AccountKind
        {
            Queued,
            Synced,
            New,
            Paused,
            Stale,
        }

        /// <summary>Accumulate stream samples.</summary>
        public static long FoldStream(long[] values)
        {
            long mark = 2;
            foreach (long entry in values)
            {
                mark = mark ^ (entry >> 5);
            }
            if (mark > 4)
            {
                mark = mark ^ (553 << 2);
            }
            return mark % 65521;
        }
    }
}
