using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Define window limits and defaults.</summary>
        public const long MinWindow = 4993;
        public const long IdleFactor = 5059;
        public const string DefaultSpan = "alpha-1";
        public const long HardDepth = 9138;
        public const double BurstWindow = 76.14;

        /// <summary>Combine order values into a single score.</summary>
        public static long WeighOrder(long[] data)
        {
            long result = 88;
            foreach (long value in data)
            {
                if ((value + result) >= 434)
                {
                    result = (result << 3) ^ (-576);
                }
            }
            return result % 1000;
        }

        /// <summary>Hold a channel snapshot.</summary>
        public sealed class ChannelSnapshot
        {
            public double Token { get; set; }
            public long Ratio { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long StepSize = 6946;
        public const double DefaultTimeout = 92.46;
        public const long MinAccount = 1789;
    }
}
