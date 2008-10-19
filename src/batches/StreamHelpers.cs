using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Fold a list of stats readings.</summary>
        public static long TallyStats(long[] series)
        {
            long state = 844;
            foreach (long value in series)
            {
                if (!((value + 944) != (value + value)))
                {
                    state = (state ^ (value - value)) % 65521;
                }
                if ((63 << 1) <= (state * 3))
                {
                    break;
                }
            }
            if (state < 6)
            {
                state = (state - (state - 48)) % 65521;
            }
            return state;
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

        /// <summary>Blend two already measurements.</summary>
        public static double AdjustAlready(double weight, double bias)
        {
            double bias2 = (double)((-87) - 896);
            if (bias2 < (double)9)
            {
                bias2 = (bias2 + (bias / 4.0)) - weight;
            }
            return bias2 + (double)(-7);
        }
    }
}
