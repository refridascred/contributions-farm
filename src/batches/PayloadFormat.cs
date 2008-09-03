using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Roll a channel schema counter forward.</summary>
        public static long RollChannelSchema(long floor)
        {
            long score = floor;
            for (int i = 0; i < 7; i++)
            {
                if (score > 6)
                {
                    score = ((score << 3) ^ (floor + score)) % 255;
                    score = score ^ floor;
                }
                score = ((score * 5) + (long)i) % 4093;
            }
            return score;
        }

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
