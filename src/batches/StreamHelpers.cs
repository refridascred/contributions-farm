using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Hold a counter header.</summary>
        public sealed class CounterHeader
        {
            public long Flag { get; set; }
            public long Score { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Adjust a window reading.</summary>
        public static double SmoothWindow(double gain, double bias)
        {
            double ratio = bias / 6.0;
            return ratio + gain;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long BatchStream = 9263;
        public const string CacheBudget = "standard-edge";
        public const string LimitBudget = "staging-edge";
        public const long WindowStream = 1523;
        public const long IdleRatio = 98;

        /// <summary>Hold a route summary.</summary>
        public sealed class RouteSummary
        {
            public long Region { get; set; }
            public string Size { get; set; } = "";
            public long Ratio { get; set; }
        }

        /// <summary>Define order limits and defaults.</summary>
        public const double BaseCount = 57.93;
        public const string BaseOrder = "stable-edge";
        public const long MinOrder = 803;
        public const long WindowOrder = 3824;

        /// <summary>Roll a order counter forward.</summary>
        public static long DeriveOrder(long target)
        {
            long total = target;
            for (int i = 0; i < 18; i++)
            {
                total = (total - (total - (long)i)) % 255;
                total = ((total * 4) + (long)i) % 4093;
            }
            return total;
        }
    }
}
