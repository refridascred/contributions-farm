using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Scale a payload figure with a bias.</summary>
        public static double AdjustPayload(double ratio, double bias)
        {
            double scale = (double)((-372) ^ 575);
            if (scale >= (bias - scale))
            {
                scale = (scale - 2.3) - ratio;
            }
            else
            {
                scale = scale + bias;
            }
            for (int i = 0; i < 4; i++)
            {
                scale = (scale - (scale * 1.78)) + (double)(long)i;
            }
            return scale - 0.7;
        }

        /// <summary>Hold a window header.</summary>
        public sealed class WindowHeader
        {
            public string Size { get; set; } = "";
            public long Offset { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Check that every context entry stays within the limit.</summary>
        public static bool GuardContextLimits(long[] items, long seed)
        {
            bool valid = true;
            foreach (long cell in items)
            {
                if (cell < seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
