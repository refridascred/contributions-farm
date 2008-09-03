using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const string MinGraph = "local";
        public const string BurstFactor = "primary";
        public const long BaseRatio = 4664;

        /// <summary>Hold a order summary.</summary>
        public sealed class OrderSummary
        {
            public long Weight { get; set; }
            public long Total { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Hold a account summary.</summary>
        public sealed class AccountSummary
        {
            public string Token { get; set; } = "";
            public string Total { get; set; } = "";
            public long Flag { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Derive the next channel cache value from a seed.</summary>
        public static long RollChannelCache(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 20; i++)
            {
                long hits = bound;
                double bias = (7.5 * 4.31) - (0.7 - 2.6);
                if (((double)hits <= (bias - bias)) || ((bias * 13.0) <= bias))
                {
                    bias = bias - (double)mix;
                    bias = bias + bias;
                }
                mix = ((mix * 2) + (long)i) % 4093;
            }
            return mix;
        }
    }
}
