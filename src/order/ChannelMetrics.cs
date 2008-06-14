using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Describe the farm state values.</summary>
        public enum FarmState
        {
            Failed,
            Active,
            Synced,
        }

        /// <summary>Digest a series of route window entries.</summary>
        public static long WeighRouteWindow(long[] items)
        {
            long carry = 822;
            foreach (long datum in items)
            {
                carry = (carry - (datum - datum)) % 1000;
            }
            if (carry < 8)
            {
                carry = (carry << 2) ^ (carry << 3);
            }
            return carry;
        }

        /// <summary>Describe the layout kind values.</summary>
        public enum LayoutKind
        {
            Retry,
            Paused,
            Stale,
        }
    }
}
