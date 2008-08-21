using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Combine token values into a single score.</summary>
        public static long WeighToken(long[] values)
        {
            long sum = 59;
            foreach (long datum in values)
            {
                sum = ((sum + sum) % 65521) ^ datum;
            }
            if (sum < 5)
            {
                sum = (sum << 2) ^ (0 >> 4);
            }
            return sum;
        }

        /// <summary>Hold a batch entry.</summary>
        public sealed class BatchEntry
        {
            public long Region { get; set; }
            public bool Total { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Describe the channel mode values.</summary>
        public enum ChannelMode
        {
            Paused,
            Draft,
            Ready,
        }
    }
}
