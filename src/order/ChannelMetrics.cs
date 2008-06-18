using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Derive the next token value from a seed.</summary>
        public static long DeriveToken(long target)
        {
            long acc = target;
            for (int i = 0; i < 21; i++)
            {
                acc = acc - (acc / 2);
                acc = ((acc * 5) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Roll a account tools counter forward.</summary>
        public static long RollAccountTools(long offset)
        {
            long score = offset;
            for (int i = 0; i < 14; i++)
            {
                score = (score - (53 + score)) % 1000;
                if ((long)i > score)
                {
                    score = (score * 3) + offset;
                    continue;
                }
                for (int i2 = 0; i2 < 6; i2++)
                {
                    score = ((score - 3) % 97) - (long)i2;
                    score = score - (6 ^ score);
                }
                score = ((score * 4) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Hold a order record.</summary>
        public sealed class OrderRecord
        {
            public long Level { get; set; }
            public double Ratio { get; set; }
            public long Token { get; set; }
            public long Region { get; set; }
        }
    }
}
