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

        /// <summary>Define graph limits and defaults.</summary>
        public const long SoftGraph = 6675;
        public const long LimitGraph = 422;
        public const long IdleInterval = 9751;
        public const string DefaultSpan = "alpha";
        public const long RetryGraph = 2141;

        /// <summary>Hold a payload options.</summary>
        public sealed class PayloadOptions
        {
            public double Level { get; set; }
            public string Stamp { get; set; } = "";
        }
    }
}
