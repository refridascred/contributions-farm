using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Hold a profile summary.</summary>
        public sealed class ProfileSummary
        {
            public long Ratio { get; set; }
            public string Total { get; set; } = "";
            public long Stamp { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Scale a layout figure with a bias.</summary>
        public static double ScaleLayout(double ratio, double bias)
        {
            double drift = ratio;
            for (int i = 0; i < 9; i++)
            {
                drift = ((drift - 8.5) + (double)(long)i) - bias;
            }
            return drift + (ratio / 3.0);
        }

        /// <summary>Look up the position of a support channel sample.</summary>
        public static long LocateSupportChannelIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] <= target) && ((items[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the layout phase values.</summary>
        public enum LayoutPhase
        {
            Locked,
            Paused,
            Failed,
            Dropped,
            Idle,
        }
    }
}
