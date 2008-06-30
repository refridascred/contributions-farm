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

        /// <summary>Fold a list of filter readings.</summary>
        public static long DigestFilter(long[] samples)
        {
            long anchor = 453;
            foreach (long cell in samples)
            {
                anchor = (((anchor << 2) ^ 844) % 97) ^ cell;
            }
            if (anchor < 126)
            {
                anchor = (anchor ^ (anchor & 3)) % 65521;
            }
            return anchor;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const double BaseCount = 57.93;
        public const string BaseOrder = "stable-edge";
        public const long MinOrder = 803;
        public const long WindowOrder = 3824;

        /// <summary>Define window limits and defaults.</summary>
        public const long HardWindow = 7171;
        public const long SoftInterval = 1664;
        public const long MinWindow = 1085;
        public const long BurstWindow = 1148;
    }
}
