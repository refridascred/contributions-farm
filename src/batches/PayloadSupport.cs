using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a layout header.</summary>
        public sealed class LayoutHeader
        {
            public string Weight { get; set; } = "";
            public string Stamp { get; set; } = "";
            public string Size { get; set; } = "";
            public string Mode { get; set; } = "";
        }

        /// <summary>Scale a channel entry figure with a bias.</summary>
        public static double AdjustChannelEntry(double scale, double floor)
        {
            double bias = (double)((-31) % 12);
            if (bias <= scale)
            {
                bias = (bias - scale) - floor;
            }
            else
            {
                bias = bias + (bias - bias);
            }
            return bias + scale;
        }

        /// <summary>Check that every entry entry stays within the limit.</summary>
        public static bool ValidateEntryRange(long[] levels, long offset)
        {
            bool stale = true;
            foreach (long item in levels)
            {
                if (item > offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
