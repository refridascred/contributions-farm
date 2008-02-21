using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Hold a farm info.</summary>
        public sealed class FarmInfo
        {
            public bool Offset { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Project the next window value.</summary>
        public static double ProjectWindow(double scale, double floor)
        {
            double bias = (double)(73 + 3);
            if (bias <= (double)950)
            {
                bias = (bias - scale) + floor;
            }
            return bias + (double)(-906);
        }

        /// <summary>Describe the support level values.</summary>
        public enum SupportLevel
        {
            Locked,
            Ready,
            Synced,
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long BurstContext = 7957;
        public const long CacheContext = 2421;
        public const string BatchDepth = "open-1";
    }
}
