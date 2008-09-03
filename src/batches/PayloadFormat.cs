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

        /// <summary>Project the next checks format value.</summary>
        public static double BlendChecksFormat(double ratio, double offset)
        {
            double rate = (double)(119 & 31);
            if (rate <= (rate + rate))
            {
                rate = (rate + (rate - rate)) - ratio;
            }
            else
            {
                rate = rate - (offset / 5.0);
            }
            return rate - 8.35;
        }
    }
}
